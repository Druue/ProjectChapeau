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
            this.addButton = new StyleGuide.BaseButton1();
            this.baseButton11 = new StyleGuide.BaseButton1();
            this.baseButton12 = new StyleGuide.BaseButton1();
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
            this.stockLabel.Location = new System.Drawing.Point(0, 28);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(828, 32);
            this.stockLabel.TabIndex = 4;
            this.stockLabel.Text = "Stock";
            this.stockLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.Control;
            this.addButton.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.addButton.Location = new System.Drawing.Point(460, 501);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(129, 43);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // baseButton11
            // 
            this.baseButton11.BackColor = System.Drawing.SystemColors.Control;
            this.baseButton11.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.baseButton11.Location = new System.Drawing.Point(54, 333);
            this.baseButton11.Name = "baseButton11";
            this.baseButton11.Size = new System.Drawing.Size(75, 23);
            this.baseButton11.TabIndex = 6;
            this.baseButton11.Text = "baseButton11";
            this.baseButton11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.baseButton11.UseVisualStyleBackColor = true;
            // 
            // baseButton12
            // 
            this.baseButton12.BackColor = System.Drawing.SystemColors.Control;
            this.baseButton12.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.baseButton12.Location = new System.Drawing.Point(677, 144);
            this.baseButton12.Name = "baseButton12";
            this.baseButton12.Size = new System.Drawing.Size(129, 43);
            this.baseButton12.TabIndex = 0;
            this.baseButton12.Text = "baseButton12";
            this.baseButton12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.baseButton12.UseVisualStyleBackColor = true;
            // 
            // StockOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 644);
            this.Controls.Add(this.baseButton12);
            this.Controls.Add(this.baseButton11);
            this.Controls.Add(this.addButton);
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
            this.Controls.SetChildIndex(this.addButton, 0);
            this.Controls.SetChildIndex(this.baseButton11, 0);
            this.Controls.SetChildIndex(this.baseButton12, 0);
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
        private StyleGuide.BaseButton1 addButton;
        private StyleGuide.BaseButton1 baseButton11;
        private StyleGuide.BaseButton1 baseButton12;
    }
}