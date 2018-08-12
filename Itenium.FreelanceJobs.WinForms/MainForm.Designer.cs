namespace Itenium.FreelanceJobs.WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FreelanceJobsGrid = new Zuby.ADGV.AdvancedDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.FreelanceJobsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FreelanceJobsGrid
            // 
            this.FreelanceJobsGrid.AllowUserToAddRows = false;
            this.FreelanceJobsGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FreelanceJobsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.FreelanceJobsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FreelanceJobsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FreelanceJobsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FreelanceJobsGrid.FilterAndSortEnabled = true;
            this.FreelanceJobsGrid.Location = new System.Drawing.Point(0, 0);
            this.FreelanceJobsGrid.Name = "FreelanceJobsGrid";
            this.FreelanceJobsGrid.ReadOnly = true;
            this.FreelanceJobsGrid.RowHeadersVisible = false;
            this.FreelanceJobsGrid.Size = new System.Drawing.Size(800, 450);
            this.FreelanceJobsGrid.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FreelanceJobsGrid);
            this.Name = "MainForm";
            this.Text = "Freelance Jobs";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FreelanceJobsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridView FreelanceJobsGrid;
    }
}

