namespace ProjectChapeau
{
    partial class OrderOverview
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chapeau_1718_DB01DataSet1 = new ProjectChapeau.Chapeau_1718_DB01DataSet1();
            this.baseButton11 = new StyleGuide.BaseButton1();
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.ordersTableAdapter = new ProjectChapeau.Chapeau_1718_DB01DataSet1TableAdapters.OrdersTableAdapter();
            this.completedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapeau_1718_DB01DataSet1)).BeginInit();
            this.backgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Text = "Orders";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.completedDataGridViewCheckBoxColumn,
            this.orderIdDataGridViewTextBoxColumn,
            this.tableIdDataGridViewTextBoxColumn,
            this.paidStatusDataGridViewTextBoxColumn,
            this.orderTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(390, 474);
            this.dataGridView1.TabIndex = 3;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.chapeau_1718_DB01DataSet1;
            // 
            // chapeau_1718_DB01DataSet1
            // 
            this.chapeau_1718_DB01DataSet1.DataSetName = "Chapeau_1718_DB01DataSet1";
            this.chapeau_1718_DB01DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // baseButton11
            // 
            this.baseButton11.BackColor = System.Drawing.SystemColors.Control;
            this.baseButton11.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.baseButton11.Location = new System.Drawing.Point(19, 641);
            this.baseButton11.Name = "baseButton11";
            this.baseButton11.Size = new System.Drawing.Size(129, 43);
            this.baseButton11.TabIndex = 0;
            this.baseButton11.Text = "Back";
            this.baseButton11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.baseButton11.UseVisualStyleBackColor = true;
            this.baseButton11.Click += new System.EventHandler(this.baseButton11_Click);
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.Controls.Add(this.dataGridView1);
            this.backgroundPanel.Controls.Add(this.baseButton11);
            this.backgroundPanel.Location = new System.Drawing.Point(67, 60);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(427, 701);
            this.backgroundPanel.TabIndex = 4;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // completedDataGridViewCheckBoxColumn
            // 
            this.completedDataGridViewCheckBoxColumn.DataPropertyName = "completed";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = false;
            this.completedDataGridViewCheckBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.completedDataGridViewCheckBoxColumn.HeaderText = "Completed";
            this.completedDataGridViewCheckBoxColumn.Name = "completedDataGridViewCheckBoxColumn";
            this.completedDataGridViewCheckBoxColumn.Width = 55;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OrangeRed;
            this.orderIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.Width = 30;
            // 
            // tableIdDataGridViewTextBoxColumn
            // 
            this.tableIdDataGridViewTextBoxColumn.DataPropertyName = "TableId";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.OrangeRed;
            this.tableIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableIdDataGridViewTextBoxColumn.HeaderText = "Table";
            this.tableIdDataGridViewTextBoxColumn.Name = "tableIdDataGridViewTextBoxColumn";
            this.tableIdDataGridViewTextBoxColumn.Width = 70;
            // 
            // paidStatusDataGridViewTextBoxColumn
            // 
            this.paidStatusDataGridViewTextBoxColumn.DataPropertyName = "PaidStatus";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.OrangeRed;
            this.paidStatusDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.paidStatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.paidStatusDataGridViewTextBoxColumn.Name = "paidStatusDataGridViewTextBoxColumn";
            // 
            // orderTimeDataGridViewTextBoxColumn
            // 
            this.orderTimeDataGridViewTextBoxColumn.DataPropertyName = "OrderTime";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.OrangeRed;
            this.orderTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.orderTimeDataGridViewTextBoxColumn.HeaderText = "Order Time";
            this.orderTimeDataGridViewTextBoxColumn.Name = "orderTimeDataGridViewTextBoxColumn";
            this.orderTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // OrderOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 799);
            this.Controls.Add(this.backgroundPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "OrderOverview";
            this.Text = "OrderOverview";
            this.Load += new System.EventHandler(this.OrderOverview_Load);
            this.Controls.SetChildIndex(this.backgroundPanel, 0);
            this.Controls.SetChildIndex(this.titleLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapeau_1718_DB01DataSet1)).EndInit();
            this.backgroundPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StyleGuide.BaseButton1 baseButton11;
        private System.Windows.Forms.Panel backgroundPanel;
        private Chapeau_1718_DB01DataSet1 chapeau_1718_DB01DataSet1;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private Chapeau_1718_DB01DataSet1TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn completedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTimeDataGridViewTextBoxColumn;
    }
}