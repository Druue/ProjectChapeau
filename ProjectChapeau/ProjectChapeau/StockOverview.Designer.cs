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
            this.stockDataGridView = new System.Windows.Forms.DataGridView();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chapeau_1718_DB01DataSet2 = new ProjectChapeau.Chapeau_1718_DB01DataSet2();
            this.backButton = new System.Windows.Forms.Button();
            this.menuTableAdapter = new ProjectChapeau.Chapeau_1718_DB01DataSet2TableAdapters.MenuTableAdapter();
            this.stockLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapeau_1718_DB01DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // stockDataGridView
            // 
            this.stockDataGridView.AllowUserToAddRows = false;
            this.stockDataGridView.AllowUserToDeleteRows = false;
            this.stockDataGridView.AutoGenerateColumns = false;
            this.stockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNameDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.stockDataGridView.DataSource = this.menuBindingSource;
            this.stockDataGridView.Location = new System.Drawing.Point(134, 113);
            this.stockDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.stockDataGridView.Name = "stockDataGridView";
            this.stockDataGridView.RowTemplate.Height = 24;
            this.stockDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.stockDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockDataGridView.Size = new System.Drawing.Size(538, 326);
            this.stockDataGridView.TabIndex = 2;
            this.stockDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockDataGridView_CellContentClick);
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.itemNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.Width = 290;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.stockDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.stockDataGridViewTextBoxColumn.HeaderText = "stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.Width = 85;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.chapeau_1718_DB01DataSet2;
            // 
            // chapeau_1718_DB01DataSet2
            // 
            this.chapeau_1718_DB01DataSet2.DataSetName = "Chapeau_1718_DB01DataSet2";
            this.chapeau_1718_DB01DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.backButton.Location = new System.Drawing.Point(134, 501);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(129, 43);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // stockLabel
            // 
            this.stockLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.stockLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLabel.Location = new System.Drawing.Point(0, 0);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(828, 32);
            this.stockLabel.TabIndex = 4;
            this.stockLabel.Text = "Stock";
            this.stockLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StockOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 644);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.stockDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Name = "StockOverview";
            this.Text = "StockOverview";
            this.Load += new System.EventHandler(this.StockOverview_Load);
            this.Controls.SetChildIndex(this.stockDataGridView, 0);
            this.Controls.SetChildIndex(this.backButton, 0);
            this.Controls.SetChildIndex(this.stockLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapeau_1718_DB01DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView stockDataGridView;
        private System.Windows.Forms.Button backButton;
        private Chapeau_1718_DB01DataSet2 chapeau_1718_DB01DataSet2;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private Chapeau_1718_DB01DataSet2TableAdapters.MenuTableAdapter menuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label stockLabel;
    }
}