namespace ProjectChapeau
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.baseButton11 = new StyleGuide.BaseButton1();
            this.Employee_dataGridView = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chapeau_1718_DB01DataSet2 = new ProjectChapeau.Chapeau_1718_DB01DataSet2();
            this.baseButton12 = new StyleGuide.BaseButton1();
            this.newLastName = new System.Windows.Forms.TextBox();
            this.newUsername = new System.Windows.Forms.TextBox();
            this.newFirstName = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.newJobRole = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.jobRole = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.groupBoxNewEmployee = new System.Windows.Forms.GroupBox();
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.employeeTableAdapter = new ProjectChapeau.Chapeau_1718_DB01DataSet2TableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapeau_1718_DB01DataSet2)).BeginInit();
            this.groupBoxNewEmployee.SuspendLayout();
            this.backgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Text = "Empoyees";
            // 
            // baseButton11
            // 
            this.baseButton11.BackColor = System.Drawing.SystemColors.Control;
            this.baseButton11.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.baseButton11.Location = new System.Drawing.Point(18, 618);
            this.baseButton11.Name = "baseButton11";
            this.baseButton11.Size = new System.Drawing.Size(129, 43);
            this.baseButton11.TabIndex = 0;
            this.baseButton11.Text = "Back";
            this.baseButton11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.baseButton11.UseVisualStyleBackColor = true;
            this.baseButton11.Click += new System.EventHandler(this.baseButton11_Click);
            // 
            // Employee_dataGridView
            // 
            this.Employee_dataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Employee_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Employee_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employee_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.jobRoleDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn});
            this.Employee_dataGridView.DataSource = this.employeeBindingSource;
            this.Employee_dataGridView.Location = new System.Drawing.Point(33, 30);
            this.Employee_dataGridView.Name = "Employee_dataGridView";
            this.Employee_dataGridView.ReadOnly = true;
            this.Employee_dataGridView.RowTemplate.Height = 24;
            this.Employee_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Employee_dataGridView.Size = new System.Drawing.Size(381, 285);
            this.Employee_dataGridView.TabIndex = 3;
            this.Employee_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Employee_dataGridView_CellContentClick);
            this.Employee_dataGridView.SelectionChanged += new System.EventHandler(this.Employee_dataGridView_SelectionChanged);
            // 
            // Edit
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = "Edit";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle2;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 50;
            // 
            // Delete
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = "Delete";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle3;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 65;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.OrangeRed;
            this.firstnameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "First name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.OrangeRed;
            this.lastnameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Last name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.OrangeRed;
            this.passwordDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobRoleDataGridViewTextBoxColumn
            // 
            this.jobRoleDataGridViewTextBoxColumn.DataPropertyName = "JobRole";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.OrangeRed;
            this.jobRoleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.jobRoleDataGridViewTextBoxColumn.HeaderText = "Job Role";
            this.jobRoleDataGridViewTextBoxColumn.Name = "jobRoleDataGridViewTextBoxColumn";
            this.jobRoleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.OrangeRed;
            this.usernameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.chapeau_1718_DB01DataSet2;
            // 
            // chapeau_1718_DB01DataSet2
            // 
            this.chapeau_1718_DB01DataSet2.DataSetName = "Chapeau_1718_DB01DataSet2";
            this.chapeau_1718_DB01DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // baseButton12
            // 
            this.baseButton12.BackColor = System.Drawing.SystemColors.Control;
            this.baseButton12.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.baseButton12.Location = new System.Drawing.Point(285, 618);
            this.baseButton12.Name = "baseButton12";
            this.baseButton12.Size = new System.Drawing.Size(129, 43);
            this.baseButton12.TabIndex = 4;
            this.baseButton12.Text = "Add";
            this.baseButton12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.baseButton12.UseVisualStyleBackColor = true;
            this.baseButton12.Click += new System.EventHandler(this.baseButton12_Click);
            // 
            // newLastName
            // 
            this.newLastName.Location = new System.Drawing.Point(221, 75);
            this.newLastName.Name = "newLastName";
            this.newLastName.Size = new System.Drawing.Size(100, 28);
            this.newLastName.TabIndex = 5;
            // 
            // newUsername
            // 
            this.newUsername.Location = new System.Drawing.Point(221, 184);
            this.newUsername.Name = "newUsername";
            this.newUsername.Size = new System.Drawing.Size(100, 28);
            this.newUsername.TabIndex = 6;
            // 
            // newFirstName
            // 
            this.newFirstName.Location = new System.Drawing.Point(221, 41);
            this.newFirstName.Name = "newFirstName";
            this.newFirstName.Size = new System.Drawing.Size(100, 28);
            this.newFirstName.TabIndex = 7;
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(221, 146);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(100, 28);
            this.newPassword.TabIndex = 8;
            // 
            // newJobRole
            // 
            this.newJobRole.Location = new System.Drawing.Point(221, 108);
            this.newJobRole.Name = "newJobRole";
            this.newJobRole.Size = new System.Drawing.Size(100, 28);
            this.newJobRole.TabIndex = 9;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(27, 44);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(99, 21);
            this.firstName.TabIndex = 10;
            this.firstName.Text = "First name:";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(27, 78);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(98, 21);
            this.lastName.TabIndex = 11;
            this.lastName.Text = "Last name:";
            // 
            // jobRole
            // 
            this.jobRole.AutoSize = true;
            this.jobRole.Location = new System.Drawing.Point(27, 153);
            this.jobRole.Name = "jobRole";
            this.jobRole.Size = new System.Drawing.Size(79, 21);
            this.jobRole.TabIndex = 12;
            this.jobRole.Text = "Job role:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(27, 115);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(94, 21);
            this.password.TabIndex = 13;
            this.password.Text = "Password:";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(27, 187);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(97, 21);
            this.userName.TabIndex = 14;
            this.userName.Text = "Username:";
            // 
            // groupBoxNewEmployee
            // 
            this.groupBoxNewEmployee.Controls.Add(this.newFirstName);
            this.groupBoxNewEmployee.Controls.Add(this.userName);
            this.groupBoxNewEmployee.Controls.Add(this.newLastName);
            this.groupBoxNewEmployee.Controls.Add(this.password);
            this.groupBoxNewEmployee.Controls.Add(this.newJobRole);
            this.groupBoxNewEmployee.Controls.Add(this.jobRole);
            this.groupBoxNewEmployee.Controls.Add(this.newPassword);
            this.groupBoxNewEmployee.Controls.Add(this.lastName);
            this.groupBoxNewEmployee.Controls.Add(this.newUsername);
            this.groupBoxNewEmployee.Controls.Add(this.firstName);
            this.groupBoxNewEmployee.Location = new System.Drawing.Point(33, 356);
            this.groupBoxNewEmployee.Name = "groupBoxNewEmployee";
            this.groupBoxNewEmployee.Size = new System.Drawing.Size(350, 243);
            this.groupBoxNewEmployee.TabIndex = 15;
            this.groupBoxNewEmployee.TabStop = false;
            this.groupBoxNewEmployee.Text = "Employee";
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.Controls.Add(this.baseButton12);
            this.backgroundPanel.Controls.Add(this.baseButton11);
            this.backgroundPanel.Controls.Add(this.Employee_dataGridView);
            this.backgroundPanel.Controls.Add(this.groupBoxNewEmployee);
            this.backgroundPanel.Location = new System.Drawing.Point(54, 59);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(441, 695);
            this.backgroundPanel.TabIndex = 16;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 799);
            this.Controls.Add(this.backgroundPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "EmployeeOverview";
            this.Text = "EmployeeOverview";
            this.Load += new System.EventHandler(this.EmployeeOverview_Load);
            this.Controls.SetChildIndex(this.backgroundPanel, 0);
            this.Controls.SetChildIndex(this.titleLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Employee_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapeau_1718_DB01DataSet2)).EndInit();
            this.groupBoxNewEmployee.ResumeLayout(false);
            this.groupBoxNewEmployee.PerformLayout();
            this.backgroundPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StyleGuide.BaseButton1 baseButton11;
        private System.Windows.Forms.DataGridView Employee_dataGridView;
        private StyleGuide.BaseButton1 baseButton12;
        private System.Windows.Forms.TextBox newLastName;
        private System.Windows.Forms.TextBox newUsername;
        private System.Windows.Forms.TextBox newFirstName;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.TextBox newJobRole;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label jobRole;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.GroupBox groupBoxNewEmployee;
        private System.Windows.Forms.Panel backgroundPanel;
        private Chapeau_1718_DB01DataSet2 chapeau_1718_DB01DataSet2;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Chapeau_1718_DB01DataSet2TableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
    }
}