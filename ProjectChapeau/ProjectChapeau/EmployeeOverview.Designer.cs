﻿namespace ProjectChapeau
{
    partial class EmployeeOverview
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Employees = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Employee_dataGridView = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chapeau_1718_DB01DataSet = new ProjectChapeau.Chapeau_1718_DB01DataSet();
            this.employeeTableAdapter = new ProjectChapeau.Chapeau_1718_DB01DataSetTableAdapters.EmployeeTableAdapter();
            this.backButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.JobRole = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.newFirstName = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.newJobRole = new System.Windows.Forms.TextBox();
            this.newLastName = new System.Windows.Forms.TextBox();
            this.newUsername = new System.Windows.Forms.TextBox();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapeau_1718_DB01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Employees
            // 
            this.Employees.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Employees.Dock = System.Windows.Forms.DockStyle.Top;
            this.Employees.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Employees.Location = new System.Drawing.Point(0, 28);
            this.Employees.Name = "Employees";
            this.Employees.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Employees.Size = new System.Drawing.Size(667, 29);
            this.Employees.TabIndex = 1;
            this.Employees.Text = "Employees";
            this.Employees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.DarkOrange;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuButton});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(667, 28);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.DarkOrange;
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(33, 24);
            this.MenuButton.Text = "|||";
            // 
            // Employee_dataGridView
            // 
            this.Employee_dataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Employee_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Employee_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employee_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn});
            this.Employee_dataGridView.DataSource = this.employeeBindingSource;
            this.Employee_dataGridView.Location = new System.Drawing.Point(239, 94);
            this.Employee_dataGridView.Name = "Employee_dataGridView";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Employee_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.Employee_dataGridView.RowTemplate.Height = 24;
            this.Employee_dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Employee_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Employee_dataGridView.Size = new System.Drawing.Size(416, 318);
            this.Employee_dataGridView.TabIndex = 4;
            this.Employee_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Employee_dataGridView_CellContentClick);
            // 
            // Edit
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle8;
            this.Edit.FillWeight = 50F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 50;
            // 
            // Delete
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle9;
            this.Delete.FillWeight = 50F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 50;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.firstnameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.lastnameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.chapeau_1718_DB01DataSet;
            // 
            // chapeau_1718_DB01DataSet
            // 
            this.chapeau_1718_DB01DataSet.DataSetName = "Chapeau_1718_DB01DataSet";
            this.chapeau_1718_DB01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.backButton.Location = new System.Drawing.Point(134, 466);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(129, 43);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.addButton.Location = new System.Drawing.Point(421, 466);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(129, 43);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(22, 110);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(78, 17);
            this.FirstName.TabIndex = 7;
            this.FirstName.Text = "First name:";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(22, 155);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(78, 17);
            this.LastName.TabIndex = 8;
            this.LastName.Text = "Last name:";
            // 
            // JobRole
            // 
            this.JobRole.AutoSize = true;
            this.JobRole.Location = new System.Drawing.Point(22, 199);
            this.JobRole.Name = "JobRole";
            this.JobRole.Size = new System.Drawing.Size(63, 17);
            this.JobRole.TabIndex = 9;
            this.JobRole.Text = "Job role:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(22, 245);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(73, 17);
            this.Password.TabIndex = 10;
            this.Password.Text = "Password:";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(22, 291);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(77, 17);
            this.Username.TabIndex = 11;
            this.Username.Text = "Username:";
            // 
            // newFirstName
            // 
            this.newFirstName.Location = new System.Drawing.Point(106, 110);
            this.newFirstName.Name = "newFirstName";
            this.newFirstName.Size = new System.Drawing.Size(100, 22);
            this.newFirstName.TabIndex = 12;
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(106, 245);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(100, 22);
            this.newPassword.TabIndex = 13;
            // 
            // newJobRole
            // 
            this.newJobRole.Location = new System.Drawing.Point(106, 199);
            this.newJobRole.Name = "newJobRole";
            this.newJobRole.Size = new System.Drawing.Size(100, 22);
            this.newJobRole.TabIndex = 14;
            // 
            // newLastName
            // 
            this.newLastName.Location = new System.Drawing.Point(106, 155);
            this.newLastName.Name = "newLastName";
            this.newLastName.Size = new System.Drawing.Size(100, 22);
            this.newLastName.TabIndex = 15;
            // 
            // newUsername
            // 
            this.newUsername.Location = new System.Drawing.Point(106, 291);
            this.newUsername.Name = "newUsername";
            this.newUsername.Size = new System.Drawing.Size(100, 22);
            this.newUsername.TabIndex = 16;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = this.employeeBindingSource;
            // 
            // EmployeeOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 572);
            this.Controls.Add(this.newUsername);
            this.Controls.Add(this.newLastName);
            this.Controls.Add(this.newJobRole);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.newFirstName);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.JobRole);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.Employee_dataGridView);
            this.Controls.Add(this.Employees);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "EmployeeOverview";
            this.Load += new System.EventHandler(this.EmployeeOverview_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapeau_1718_DB01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Employees;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuButton;
        private System.Windows.Forms.DataGridView Employee_dataGridView;
        private Chapeau_1718_DB01DataSet chapeau_1718_DB01DataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Chapeau_1718_DB01DataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label JobRole;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox newFirstName;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.TextBox newJobRole;
        private System.Windows.Forms.TextBox newLastName;
        private System.Windows.Forms.TextBox newUsername;
        private System.Windows.Forms.BindingSource bindingSource;
    }
}