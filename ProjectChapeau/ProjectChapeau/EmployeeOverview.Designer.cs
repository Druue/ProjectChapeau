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
            this.Employees = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Employee_dataGridView = new System.Windows.Forms.DataGridView();
            this.chapeau_1718_DB01DataSet = new ProjectChapeau.Chapeau_1718_DB01DataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new ProjectChapeau.Chapeau_1718_DB01DataSetTableAdapters.EmployeeTableAdapter();
            this.edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButtonEmployeeOverview = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapeau_1718_DB01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
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
            this.Employee_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employee_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edit,
            this.delete,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn});
            this.Employee_dataGridView.DataSource = this.employeeBindingSource;
            this.Employee_dataGridView.Location = new System.Drawing.Point(134, 110);
            this.Employee_dataGridView.Name = "Employee_dataGridView";
            this.Employee_dataGridView.RowTemplate.Height = 24;
            this.Employee_dataGridView.Size = new System.Drawing.Size(416, 318);
            this.Employee_dataGridView.TabIndex = 4;
            this.Employee_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Employee_dataGridView_CellContentClick);
            // 
            // chapeau_1718_DB01DataSet
            // 
            this.chapeau_1718_DB01DataSet.DataSetName = "Chapeau_1718_DB01DataSet";
            this.chapeau_1718_DB01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.chapeau_1718_DB01DataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // edit
            // 
            this.edit.HeaderText = "Edit";
            this.edit.Name = "edit";
            // 
            // delete
            // 
            this.delete.HeaderText = "Delete";
            this.delete.Name = "delete";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // backButtonEmployeeOverview
            // 
            this.backButtonEmployeeOverview.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.backButtonEmployeeOverview.Location = new System.Drawing.Point(132, 463);
            this.backButtonEmployeeOverview.Name = "backButtonEmployeeOverview";
            this.backButtonEmployeeOverview.Size = new System.Drawing.Size(129, 43);
            this.backButtonEmployeeOverview.TabIndex = 5;
            this.backButtonEmployeeOverview.Text = "Back";
            this.backButtonEmployeeOverview.UseVisualStyleBackColor = false;
            this.backButtonEmployeeOverview.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeeOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 572);
            this.Controls.Add(this.backButtonEmployeeOverview);
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
            ((System.ComponentModel.ISupportInitialize)(this.chapeau_1718_DB01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button backButtonEmployeeOverview;
    }
}