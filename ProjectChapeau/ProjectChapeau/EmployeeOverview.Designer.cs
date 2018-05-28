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
            this.backButtonEmployeeOverview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Employee_dataGridView = new System.Windows.Forms.DataGridView();
            this.chapeau_1718_DB01DataSet = new ProjectChapeau.Chapeau_1718_DB01DataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new ProjectChapeau.Chapeau_1718_DB01DataSetTableAdapters.EmployeeTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapeau_1718_DB01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // backButtonEmployeeOverview
            // 
            this.backButtonEmployeeOverview.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.backButtonEmployeeOverview.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButtonEmployeeOverview.Location = new System.Drawing.Point(99, 478);
            this.backButtonEmployeeOverview.Name = "backButtonEmployeeOverview";
            this.backButtonEmployeeOverview.Size = new System.Drawing.Size(82, 36);
            this.backButtonEmployeeOverview.TabIndex = 0;
            this.backButtonEmployeeOverview.Text = "Back";
            this.backButtonEmployeeOverview.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(667, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employees";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(667, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(33, 24);
            this.toolStripMenuItem1.Text = "|||";
            // 
            // Employee_dataGridView
            // 
            this.Employee_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // EmployeeOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 572);
            this.Controls.Add(this.Employee_dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButtonEmployeeOverview);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EmployeeOverview";
            this.Load += new System.EventHandler(this.EmployeeOverview_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapeau_1718_DB01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButtonEmployeeOverview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridView Employee_dataGridView;
        private Chapeau_1718_DB01DataSet chapeau_1718_DB01DataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Chapeau_1718_DB01DataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
    }
}