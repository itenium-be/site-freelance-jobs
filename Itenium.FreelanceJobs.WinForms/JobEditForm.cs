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
            var locs = new[] {"Antwerpen", "Gent", "Brussel"};

            foreach (var loc in locs)
                Location.Items.Add(loc);
        }

        public void SetJob(FreelanceJob job, Action<FreelanceJob> onChange = null)
        {
            _job = job;
            _onChange = onChange;

            JobDeletedInfoGroupbox.Text = job.Deleted ? "DELETED Job" : "PUBLISHED Job";
            Location.Text = job.Location;
            Title.Text = job.Title;
            Username.Text = job.Username;
            DateAdded.Value = job.DateAdded;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PublishButton_Click(object sender, EventArgs e)
        {
            _job.Title = Title.Text;
            _job.Location = Location.Text;

            _onChange?.Invoke(_job);
            Close();
        }
    }
}
