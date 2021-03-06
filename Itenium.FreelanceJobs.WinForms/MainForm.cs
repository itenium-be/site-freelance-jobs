﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Itenium.FreelanceJobs.DataAccess;
using Itenium.FreelanceJobs.DataAccess.Models;
using AutoUpdaterDotNET;

namespace Itenium.FreelanceJobs.WinForms
{
    public partial class MainForm : Form
    {
        private IJobsService _service;
        private ICollection<FreelanceJob> _jobs;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ServicePointManager.SecurityProtocol = (ServicePointManager.SecurityProtocol & SecurityProtocolType.Ssl3) 
                | (SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12);
            AutoUpdater.ShowSkipButton = false;
            AutoUpdater.ShowRemindLaterButton = false;
            AutoUpdater.Mandatory = true;
            AutoUpdater.RunUpdateAsAdmin = false;
            AutoUpdater.Start(Properties.Settings.Default.AutoUpdateUrl);

            _service = JobsServiceFactory.GetService();
            _jobs = _service.GetJobs().ToList();

            Version version = Assembly.GetEntryAssembly().GetName().Version;
            Text += $" (v{version})";

            ConfigureGrid();
            BindGrid();
        }

        private void ConfigureGrid()
        {
            // FreelanceJobsGrid.Sort(FreelanceJobsGrid.Columns["Title"], ListSortDirection.Ascending);

            FreelanceJobsGrid.RowTemplate.Height = 120;
            DescriptionGridColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DescriptionGridColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            MainForm_ResizeEnd(this, EventArgs.Empty);
        }

        private void BindGrid()
        {
            var dt = dataSet1.Tables[0];
            dt.Clear();
            var jobs = GetJobs();
            foreach (var job in jobs.OrderByDescending(x => x.DateAdded))
            {
                var row = dt.NewRow();
                row[nameof(FreelanceJob.Id)] = job.Id;
                row[nameof(FreelanceJob.Title)] = job.Title;
                row[nameof(FreelanceJob.Location)] = job.Location;
                row[nameof(FreelanceJob.Description)] = job.Description;
                row[nameof(FreelanceJob.Username)] = job.Username;
                row[nameof(FreelanceJob.DateAdded)] = job.DateAdded;
                row[nameof(FreelanceJob.UnpublishDate)] = job.UnpublishDate;
                row[nameof(FreelanceJob.Published)] = job.Published;
                row[nameof(FreelanceJob.Slug)] = job.Slug;
                dt.Rows.Add(row);
            }
        }

        private IEnumerable<FreelanceJob> GetJobs()
        {
            IEnumerable<FreelanceJob> jobs = _jobs;
            if (!SeeDeletedCheckbox.Checked)
                jobs = jobs.Where(x => x.Published);

            string needle = SearchNeedle.Text;
            if (!string.IsNullOrWhiteSpace(needle))
            {
                jobs = jobs.Where(x => FilterJob(x, needle));
            }

            return jobs.ToArray();
        }

        private static bool FilterJob(FreelanceJob job, string needle)
        {
            var str = Newtonsoft.Json.JsonConvert.SerializeObject(job);
            return str.ToUpperInvariant().Contains(needle.ToUpperInvariant());
        }

        private void SeeDeletedCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            for (int i = 0; i <= FreelanceJobsGrid.Columns.Count - 1; i++)
            {
                FreelanceJobsGrid.Columns[i].Width = FreelanceJobsGrid.Columns[i].Width;
            }
        }

        private void NewJobButton_Click(object sender, EventArgs e)
        {
            var frm = new JobEditForm();
            var job = new FreelanceJob();
            job.Id = _jobs.Max(x => x.Id) + 1;
            job.Published = true;
            frm.SetJob(job, newJob =>
            {
                _jobs.Add(newJob);
                _service.SaveJobs(_jobs, newJob, ChangeType.Published);
                BindGrid();
            });
            frm.Show();
        }

        private void FreelanceJobsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // EDIT a FreelanceJob
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var job = GetJob(e.RowIndex);

                var frm = new JobEditForm();
                frm.SetJob(job, updatedJob =>
                {
                    _service.SaveJobs(_jobs, updatedJob, ChangeType.Updated);
                    BindGrid();
                });
                frm.Show();
            }

            FreelanceJobsGrid.EndEdit();
        }

        private FreelanceJob GetJob(int rowIndex)
        {
            var row = FreelanceJobsGrid.Rows[rowIndex];
            int id = int.Parse(row.Cells[nameof(FreelanceJob.Id)].Value.ToString());
            var job = _jobs.Single(x => x.Id == id);
            return job;
        }

        private void FreelanceJobsGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // DELETE / RESTORE a FreelanceJob
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                var job = GetJob(e.RowIndex);

                bool toDelete = job.Published;
                var (actionWord, yes, no) = GetDeleteMessageParts(toDelete);

                var result = MessageBox.Show(
                    $"{actionWord} '{job.Title}'?"
                        + Environment.NewLine
                        + $"{yes}{Environment.NewLine}{no}",
                    $"{actionWord} freelance job?",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    job.Published = !job.Published;
                    var row = FreelanceJobsGrid.Rows[e.RowIndex];
                    row.Cells[UnpublishDate.Name].Value = job.UnpublishDate;
                    _service.SaveJobs(_jobs, job, toDelete ? ChangeType.Removed : ChangeType.Published);
                }
                else
                {
                    FreelanceJobsGrid.CellValueChanged -= FreelanceJobsGrid_CellValueChanged;
                    var row = FreelanceJobsGrid.Rows[e.RowIndex];
                    row.Cells[DeletedGridColumn.Name].Value = toDelete;
                    FreelanceJobsGrid.CellValueChanged += FreelanceJobsGrid_CellValueChanged;
                }
            }
        }

        private static (string actionWords, string yes, string no) GetDeleteMessageParts(bool toDelete)
        {
            if (toDelete)
                return ("Delete", "Click Yes to remove this freelance job from the site.", "Click No to keep the job on the site.");

            return ("Restore", "Click Yes to put this freelance job back on the site.", "Click No to keep the job offline.");
        }

        private void SearchNeedle_KeyPress(object sender, KeyPressEventArgs e)
        {
            BindGrid();
        }
    }
}
