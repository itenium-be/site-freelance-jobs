﻿namespace Itenium.FreelanceJobs.WinForms
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
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.TitleColumn = new System.Data.DataColumn();
            this.LocationColumn = new System.Data.DataColumn();
            this.DescriptionColumn = new System.Data.DataColumn();
            this.UsernameColumn = new System.Data.DataColumn();
            this.DateAddedColumn = new System.Data.DataColumn();
            this.DeletedColumn = new System.Data.DataColumn();
            this.FreelanceJobsGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TitleGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsernameGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAddedGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletedGridColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EditGridColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchNeedle = new System.Windows.Forms.TextBox();
            this.NewJobButton = new System.Windows.Forms.Button();
            this.SeeDeletedCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.IdGridColumn = new System.Data.DataColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreelanceJobsGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.IdGridColumn});
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
            this.DeletedColumn.ColumnName = "Deleted";
            this.DeletedColumn.DataType = typeof(bool);
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
            this.FreelanceJobsGrid.TabIndex = 0;
            this.FreelanceJobsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FreelanceJobsGrid_CellContentClick);
            this.FreelanceJobsGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.FreelanceJobsGrid_CellValueChanged);
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
            // TitleGridColumn
            // 
            this.TitleGridColumn.DataPropertyName = "Title";
            this.TitleGridColumn.HeaderText = "Title";
            this.TitleGridColumn.Name = "TitleGridColumn";
            this.TitleGridColumn.ReadOnly = true;
            this.TitleGridColumn.Width = 250;
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
            this.DeletedGridColumn.DataPropertyName = "Deleted";
            this.DeletedGridColumn.HeaderText = "Deleted";
            this.DeletedGridColumn.Name = "DeletedGridColumn";
            // 
            // EditGridColumn
            // 
            this.EditGridColumn.HeaderText = "Edit";
            this.EditGridColumn.Name = "EditGridColumn";
            this.EditGridColumn.Text = "Edit";
            this.EditGridColumn.UseColumnTextForButtonValue = true;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NewJobButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 59);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // SearchNeedle
            // 
            this.SearchNeedle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchNeedle.Location = new System.Drawing.Point(7, 19);
            this.SearchNeedle.Name = "SearchNeedle";
            this.SearchNeedle.Size = new System.Drawing.Size(180, 31);
            this.SearchNeedle.TabIndex = 4;
            // 
            // NewJobButton
            // 
            this.NewJobButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewJobButton.Location = new System.Drawing.Point(20, 14);
            this.NewJobButton.Name = "NewJobButton";
            this.NewJobButton.Size = new System.Drawing.Size(172, 38);
            this.NewJobButton.TabIndex = 3;
            this.NewJobButton.Text = "New Job";
            this.NewJobButton.UseVisualStyleBackColor = true;
            this.NewJobButton.Click += new System.EventHandler(this.NewJobButton_Click);
            // 
            // SeeDeletedCheckbox
            // 
            this.SeeDeletedCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SeeDeletedCheckbox.AutoSize = true;
            this.SeeDeletedCheckbox.Location = new System.Drawing.Point(303, 26);
            this.SeeDeletedCheckbox.Name = "SeeDeletedCheckbox";
            this.SeeDeletedCheckbox.Size = new System.Drawing.Size(83, 17);
            this.SeeDeletedCheckbox.TabIndex = 2;
            this.SeeDeletedCheckbox.Text = "See deleted";
            this.SeeDeletedCheckbox.UseVisualStyleBackColor = true;
            this.SeeDeletedCheckbox.CheckedChanged += new System.EventHandler(this.SeeDeletedCheckbox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchButton);
            this.groupBox2.Controls.Add(this.SearchNeedle);
            this.groupBox2.Controls.Add(this.SeeDeletedCheckbox);
            this.groupBox2.Location = new System.Drawing.Point(209, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 59);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(193, 14);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(104, 39);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // IdGridColumn
            // 
            this.IdGridColumn.ColumnName = "Id";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 495);
            this.Controls.Add(this.tableLayoutPanel1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsernameGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAddedGridColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DeletedGridColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditGridColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchNeedle;
        private System.Windows.Forms.CheckBox SeeDeletedCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button NewJobButton;
        private System.Data.DataColumn IdGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}

