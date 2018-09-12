using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Itenium.FreelanceJobs.DataAccess.Models;

namespace Itenium.FreelanceJobs.WinForms
{
    public partial class JobEditForm : Form
    {
        private FreelanceJob _job;
        private Action<FreelanceJob> _onChange;

        public JobEditForm()
        {
            InitializeComponent();
        }

        private void JobEditForm_Load(object sender, EventArgs e)
        {
            var locs = new[] {
                "Gent",
                "Brussel",
                "Antwerpen",
                "Leuven",
                "Mechelen",
                "Aalst",
                "Hasselt",
                "Oost Vlaanderen",
                "West Vlaanderen",
                "Limburg",
                "Waals Brabant",
                "Kempen",
                "Vlaams Brabant"
            };

            foreach (var loc in locs.OrderBy(x => x))
                Location.Items.Add(loc);
        }

        public void SetJob(FreelanceJob job, Action<FreelanceJob> onChange = null)
        {
            _job = job;
            _onChange = onChange;

            JobDeletedInfoGroupbox.Text = job.Published ? "PUBLISHED Job" : "DELETED Job";
            JobDeletedInfoGroupbox.Text += $" (Id: {job.Id})";
            Text = $"{job.Title}";
            if (string.IsNullOrWhiteSpace(job.Username))
            {
                JobDeletedInfoGroupbox.Text = "NEW Job";
            }
            if (!job.Published)
            {
                PublishButton.Text = "Save Changes";
            }
            Location.Text = job.Location;
            Title.Text = job.Title;
            Username.Text = job.Username;
            DateAdded.Value = job.DateAdded;
            Description.HtmlEditControl.DocumentText = job.Description;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PublishButton_Click(object sender, EventArgs e)
        {
            _job.Title = Title.Text;
            _job.Location = Location.Text;
            _job.Description = Description.HtmlEditControl.DocumentText;

            _onChange?.Invoke(_job);
            Close();
        }
    }
}
