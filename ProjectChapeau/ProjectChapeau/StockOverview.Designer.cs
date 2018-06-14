namespace ProjectChapeau
{
    partial class StockOverview
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
            this.baseButton11 = new StyleGuide.BaseButton1();
            this.stockDataGridView = new System.Windows.Forms.DataGridView();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chapeau_1718_DB01DataSet = new ProjectChapeau.Chapeau_1718_DB01DataSet();
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.baseButton12 = new StyleGuide.BaseButton1();
            this.menuTableAdapter = new ProjectChapeau.Chapeau_1718_DB01DataSetTableAdapters.MenuTableAdapter();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapeau_1718_DB01DataSet)).BeginInit();
            this.backgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Text = "Stock";
            // 
            // baseButton11
            // 
            this.baseButton11.BackColor = System.Drawing.SystemColors.Control;
            this.baseButton11.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.baseButton11.Location = new System.Drawing.Point(36, 633);
            this.baseButton11.Name = "baseButton11";
            this.baseButton11.Size = new System.Drawing.Size(129, 43);
            this.baseButton11.TabIndex = 0;
            this.baseButton11.Text = "Back";
            this.baseButton11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.baseButton11.UseVisualStyleBackColor = true;
            this.baseButton11.Click += new System.EventHandler(this.baseButton11_Click);
            // 
            // stockDataGridView
            // 
            this.stockDataGridView.AllowUserToDeleteRows = false;
            this.stockDataGridView.AutoGenerateColumns = false;
            this.stockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.stockDataGridViewTextBoxColumn});
            this.stockDataGridView.DataSource = this.menuBindingSource;
            this.stockDataGridView.Location = new System.Drawing.Point(90, 87);
            this.stockDataGridView.Name = "stockDataGridView";
            this.stockDataGridView.RowTemplate.Height = 24;
            this.stockDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockDataGridView.Size = new System.Drawing.Size(364, 508);
            this.stockDataGridView.TabIndex = 3;
            this.stockDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockDataGridView_CellContentClick);
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.chapeau_1718_DB01DataSet;
            // 
            // chapeau_1718_DB01DataSet
            // 
            this.chapeau_1718_DB01DataSet.DataSetName = "Chapeau_1718_DB01DataSet";
            this.chapeau_1718_DB01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.Controls.Add(this.baseButton12);
            this.backgroundPanel.Controls.Add(this.baseButton11);
            this.backgroundPanel.Location = new System.Drawing.Point(54, 60);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(433, 704);
            this.backgroundPanel.TabIndex = 4;
            // 
            // baseButton12
            // 
            this.baseButton12.BackColor = System.Drawing.SystemColors.Control;
            this.baseButton12.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.baseButton12.Location = new System.Drawing.Point(271, 633);
            this.baseButton12.Name = "baseButton12";
            this.baseButton12.Size = new System.Drawing.Size(129, 43);
            this.baseButton12.TabIndex = 0;
            this.baseButton12.Text = "Add";
            this.baseButton12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.baseButton12.UseVisualStyleBackColor = true;
            this.baseButton12.Click += new System.EventHandler(this.baseButton12_Click_1);
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OrangeRed;
            this.ItemName.DefaultCellStyle = dataGridViewCellStyle1;
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 200;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OrangeRed;
            this.stockDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.stockDataGridViewTextBoxColumn.HeaderText = "stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            // 
            // StockOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 799);
            this.Controls.Add(this.stockDataGridView);
            this.Controls.Add(this.backgroundPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "StockOverview";
            this.Text = "StockOverview";
            this.Load += new System.EventHandler(this.StockOverview_Load);
            this.Controls.SetChildIndex(this.backgroundPanel, 0);
            this.Controls.SetChildIndex(this.stockDataGridView, 0);
            this.Controls.SetChildIndex(this.titleLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapeau_1718_DB01DataSet)).EndInit();
            this.backgroundPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StyleGuide.BaseButton1 baseButton11;
        private System.Windows.Forms.DataGridView stockDataGridView;
        private System.Windows.Forms.Panel backgroundPanel;
        private Chapeau_1718_DB01DataSet chapeau_1718_DB01DataSet;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private Chapeau_1718_DB01DataSetTableAdapters.MenuTableAdapter menuTableAdapter;
        private StyleGuide.BaseButton1 baseButton12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
    }
}