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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.TitleColumn = new System.Data.DataColumn();
            this.LocationColumn = new System.Data.DataColumn();
            this.DescriptionColumn = new System.Data.DataColumn();
            this.UsernameColumn = new System.Data.DataColumn();
            this.DateAddedColumn = new System.Data.DataColumn();
            this.DeletedColumn = new System.Data.DataColumn();
            this.IdGridColumn = new System.Data.DataColumn();
            this.SlugColumn = new System.Data.DataColumn();
            this.FreelanceJobsGrid = new System.Windows.Forms.DataGridView();
            this.TitleGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsernameGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAddedGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletedGridColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EditGridColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchNeedle = new System.Windows.Forms.TextBox();
            this.SeeDeletedCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NewJobButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreelanceJobsGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.TitleColumn,
            this.LocationColumn,
            this.DescriptionColumn,
            this.UsernameColumn,
            this.DateAddedColumn,
            this.DeletedColumn,
            this.IdGridColumn,
            this.SlugColumn});
            this.dataTable1.TableName = "Table1";
            // 
            // TitleColumn
            // 
            this.TitleColumn.ColumnName = "Title";
            // 
            // LocationColumn
            // 
            this.LocationColumn.ColumnName = "Location";
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.ColumnName = "Description";
            // 
            // UsernameColumn
            // 
            this.UsernameColumn.Caption = "Added by";
            this.UsernameColumn.ColumnName = "Username";
            // 
            // DateAddedColumn
            // 
            this.DateAddedColumn.Caption = "Added on";
            this.DateAddedColumn.ColumnName = "DateAdded";
            this.DateAddedColumn.DataType = typeof(System.DateTime);
            // 
            // DeletedColumn
            // 
            this.DeletedColumn.ColumnName = "Published";
            this.DeletedColumn.DataType = typeof(bool);
            // 
            // IdGridColumn
            // 
            this.IdGridColumn.ColumnName = "Id";
            // 
            // SlugColumn
            // 
            this.SlugColumn.ColumnName = "Slug";
            // 
            // FreelanceJobsGrid
            // 
            this.FreelanceJobsGrid.AllowUserToAddRows = false;
            this.FreelanceJobsGrid.AllowUserToDeleteRows = false;
            this.FreelanceJobsGrid.AllowUserToOrderColumns = true;
            this.FreelanceJobsGrid.AutoGenerateColumns = false;
            this.FreelanceJobsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FreelanceJobsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleGridColumn,
            this.Slug,
            this.LocationGridColumn,
            this.DescriptionGridColumn,
            this.UsernameGridColumn,
            this.DateAddedGridColumn,
            this.DeletedGridColumn,
            this.EditGridColumn,
            this.Id});
            this.FreelanceJobsGrid.DataMember = "Table1";
            this.FreelanceJobsGrid.DataSource = this.dataSet1;
            this.FreelanceJobsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FreelanceJobsGrid.Location = new System.Drawing.Point(3, 68);
            this.FreelanceJobsGrid.Name = "FreelanceJobsGrid";
            this.FreelanceJobsGrid.Size = new System.Drawing.Size(1068, 424);
            this.FreelanceJobsGrid.TabIndex = 4;
            this.FreelanceJobsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FreelanceJobsGrid_CellContentClick);
            this.FreelanceJobsGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.FreelanceJobsGrid_CellValueChanged);
            // 
            // TitleGridColumn
            // 
            this.TitleGridColumn.DataPropertyName = "Title";
            this.TitleGridColumn.HeaderText = "Title";
            this.TitleGridColumn.Name = "TitleGridColumn";
            this.TitleGridColumn.ReadOnly = true;
            this.TitleGridColumn.Width = 250;
            // 
            // Slug
            // 
            this.Slug.DataPropertyName = "Slug";
            this.Slug.HeaderText = "Slug";
            this.Slug.Name = "Slug";
            this.Slug.Visible = false;
            // 
            // LocationGridColumn
            // 
            this.LocationGridColumn.DataPropertyName = "Location";
            this.LocationGridColumn.HeaderText = "Location";
            this.LocationGridColumn.Name = "LocationGridColumn";
            this.LocationGridColumn.ReadOnly = true;
            // 
            // DescriptionGridColumn
            // 
            this.DescriptionGridColumn.DataPropertyName = "Description";
            this.DescriptionGridColumn.HeaderText = "Description";
            this.DescriptionGridColumn.Name = "DescriptionGridColumn";
            this.DescriptionGridColumn.ReadOnly = true;
            this.DescriptionGridColumn.Width = 200;
            // 
            // UsernameGridColumn
            // 
            this.UsernameGridColumn.DataPropertyName = "Username";
            this.UsernameGridColumn.HeaderText = "Username";
            this.UsernameGridColumn.Name = "UsernameGridColumn";
            this.UsernameGridColumn.ReadOnly = true;
            // 
            // DateAddedGridColumn
            // 
            this.DateAddedGridColumn.DataPropertyName = "DateAdded";
            this.DateAddedGridColumn.HeaderText = "DateAdded";
            this.DateAddedGridColumn.Name = "DateAddedGridColumn";
            this.DateAddedGridColumn.ReadOnly = true;
            // 
            // DeletedGridColumn
            // 
            this.DeletedGridColumn.DataPropertyName = "Published";
            this.DeletedGridColumn.HeaderText = "Toggle published";
            this.DeletedGridColumn.Name = "DeletedGridColumn";
            // 
            // EditGridColumn
            // 
            this.EditGridColumn.HeaderText = "Edit";
            this.EditGridColumn.Name = "EditGridColumn";
            this.EditGridColumn.Text = "Edit";
            this.EditGridColumn.UseColumnTextForButtonValue = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.FreelanceJobsGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.66666F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1074, 495);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 65);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchNeedle);
            this.groupBox2.Controls.Add(this.SeeDeletedCheckbox);
            this.groupBox2.Location = new System.Drawing.Point(209, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 59);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // SearchNeedle
            // 
            this.SearchNeedle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchNeedle.Location = new System.Drawing.Point(7, 19);
            this.SearchNeedle.Name = "SearchNeedle";
            this.SearchNeedle.Size = new System.Drawing.Size(288, 31);
            this.SearchNeedle.TabIndex = 1;
            this.SearchNeedle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchNeedle_KeyPress);
            // 
            // SeeDeletedCheckbox
            // 
            this.SeeDeletedCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SeeDeletedCheckbox.AutoSize = true;
            this.SeeDeletedCheckbox.Location = new System.Drawing.Point(301, 26);
            this.SeeDeletedCheckbox.Name = "SeeDeletedCheckbox";
            this.SeeDeletedCheckbox.Size = new System.Drawing.Size(111, 17);
            this.SeeDeletedCheckbox.TabIndex = 3;
            this.SeeDeletedCheckbox.Text = "See not &published";
            this.SeeDeletedCheckbox.UseVisualStyleBackColor = true;
            this.SeeDeletedCheckbox.CheckedChanged += new System.EventHandler(this.SeeDeletedCheckbox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NewJobButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 59);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // NewJobButton
            // 
            this.NewJobButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewJobButton.Location = new System.Drawing.Point(9, 14);
            this.NewJobButton.Name = "NewJobButton";
            this.NewJobButton.Size = new System.Drawing.Size(183, 38);
            this.NewJobButton.TabIndex = 0;
            this.NewJobButton.Text = "&New Job";
            this.NewJobButton.UseVisualStyleBackColor = true;
            this.NewJobButton.Click += new System.EventHandler(this.NewJobButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 495);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Freelance Jobs";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreelanceJobsGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn TitleColumn;
        private System.Data.DataColumn LocationColumn;
        private System.Data.DataColumn DescriptionColumn;
        private System.Data.DataColumn UsernameColumn;
        private System.Data.DataColumn DateAddedColumn;
        private System.Data.DataColumn DeletedColumn;
        private System.Windows.Forms.DataGridView FreelanceJobsGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SearchNeedle;
        private System.Windows.Forms.CheckBox SeeDeletedCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button NewJobButton;
        private System.Data.DataColumn IdGridColumn;
        private System.Data.DataColumn SlugColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slug;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsernameGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAddedGridColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DeletedGridColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}

