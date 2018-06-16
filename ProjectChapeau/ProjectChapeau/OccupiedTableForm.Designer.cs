namespace ProjectChapeau
{
    partial class OccupiedTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OccupiedTableForm));
            this.FormPanel = new System.Windows.Forms.Panel();
            this.statusDisplayLabel = new System.Windows.Forms.Label();
            this.textStatusLabel = new System.Windows.Forms.Label();
            this.tableReceiptListView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dots = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.startPaymentButton = new System.Windows.Forms.Button();
            this.cancelOrderButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.FormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormPanel
            // 
            this.FormPanel.Controls.Add(this.statusDisplayLabel);
            this.FormPanel.Controls.Add(this.textStatusLabel);
            this.FormPanel.Controls.Add(this.tableReceiptListView);
            this.FormPanel.Controls.Add(this.statusComboBox);
            this.FormPanel.Controls.Add(this.backButton);
            this.FormPanel.Controls.Add(this.startPaymentButton);
            this.FormPanel.Controls.Add(this.cancelOrderButton);
            this.FormPanel.Controls.Add(this.addItemButton);
            this.FormPanel.Location = new System.Drawing.Point(12, 1);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(460, 718);
            this.FormPanel.TabIndex = 0;
            // 
            // statusDisplayLabel
            // 
            this.statusDisplayLabel.AutoSize = true;
            this.statusDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDisplayLabel.Location = new System.Drawing.Point(153, 141);
            this.statusDisplayLabel.Name = "statusDisplayLabel";
            this.statusDisplayLabel.Size = new System.Drawing.Size(146, 25);
            this.statusDisplayLabel.TabIndex = 7;
            this.statusDisplayLabel.Text = "Waiting Order";
            this.statusDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textStatusLabel
            // 
            this.textStatusLabel.AutoSize = true;
            this.textStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStatusLabel.Location = new System.Drawing.Point(175, 105);
            this.textStatusLabel.Name = "textStatusLabel";
            this.textStatusLabel.Size = new System.Drawing.Size(100, 25);
            this.textStatusLabel.TabIndex = 6;
            this.textStatusLabel.Text = "STATUS:";
            // 
            // tableReceiptListView
            // 
            this.tableReceiptListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.dots,
            this.price});
            this.tableReceiptListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.tableReceiptListView.Location = new System.Drawing.Point(60, 191);
            this.tableReceiptListView.Name = "tableReceiptListView";
            this.tableReceiptListView.Size = new System.Drawing.Size(328, 211);
            this.tableReceiptListView.TabIndex = 5;
            this.tableReceiptListView.UseCompatibleStateImageBehavior = false;
            this.tableReceiptListView.View = System.Windows.Forms.View.Details;
            this.tableReceiptListView.SelectedIndexChanged += new System.EventHandler(this.tableReceiptListView_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Width = 90;
            // 
            // dots
            // 
            this.dots.Width = 90;
            // 
            // statusComboBox
            // 
            this.statusComboBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Waiting Order",
            "Served"});
            this.statusComboBox.Location = new System.Drawing.Point(60, 437);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(328, 24);
            this.statusComboBox.TabIndex = 4;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(31, 647);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(128, 45);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // startPaymentButton
            // 
            this.startPaymentButton.BackColor = System.Drawing.Color.DarkOrange;
            this.startPaymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startPaymentButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startPaymentButton.Location = new System.Drawing.Point(60, 567);
            this.startPaymentButton.Name = "startPaymentButton";
            this.startPaymentButton.Size = new System.Drawing.Size(328, 51);
            this.startPaymentButton.TabIndex = 2;
            this.startPaymentButton.Text = "Start Payment";
            this.startPaymentButton.UseVisualStyleBackColor = false;
            this.startPaymentButton.Click += new System.EventHandler(this.startPaymentButton_Click);
            // 
            // cancelOrderButton
            // 
            this.cancelOrderButton.BackColor = System.Drawing.Color.Brown;
            this.cancelOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelOrderButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelOrderButton.Location = new System.Drawing.Point(60, 498);
            this.cancelOrderButton.Name = "cancelOrderButton";
            this.cancelOrderButton.Size = new System.Drawing.Size(161, 51);
            this.cancelOrderButton.TabIndex = 1;
            this.cancelOrderButton.Text = "Cancel Order";
            this.cancelOrderButton.UseVisualStyleBackColor = false;
            // 
            // addItemButton
            // 
            this.addItemButton.BackColor = System.Drawing.Color.OliveDrab;
            this.addItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addItemButton.Location = new System.Drawing.Point(227, 498);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(161, 51);
            this.addItemButton.TabIndex = 0;
            this.addItemButton.Text = "Add a new Item";
            this.addItemButton.UseVisualStyleBackColor = false;
            // 
            // OccupiedTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 753);
            this.Controls.Add(this.FormPanel);
            this.Name = "OccupiedTableForm";
            this.Text = "OccupiedTableForm";
            this.FormPanel.ResumeLayout(false);
            this.FormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormPanel;
        private System.Windows.Forms.Label statusDisplayLabel;
        private System.Windows.Forms.Label textStatusLabel;
        private System.Windows.Forms.ListView tableReceiptListView;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button startPaymentButton;
        private System.Windows.Forms.Button cancelOrderButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader dots;
        private System.Windows.Forms.ColumnHeader price;
    }
}