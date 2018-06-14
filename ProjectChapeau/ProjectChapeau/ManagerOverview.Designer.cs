namespace ProjectChapeau
{
    partial class ManagerOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerOverview));
            this.baseButton11 = new StyleGuide.BaseButton1();
            this.baseButton12 = new StyleGuide.BaseButton1();
            this.baseButton13 = new StyleGuide.BaseButton1();
            this.baseButton14 = new StyleGuide.BaseButton1();
            this.testLabelManager = new System.Windows.Forms.Label();
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.backgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Text = "Manager Overview";
            // 
            // baseButton11
            // 
            this.baseButton11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.baseButton11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseButton11.Image = ((System.Drawing.Image)(resources.GetObject("baseButton11.Image")));
            this.baseButton11.Location = new System.Drawing.Point(138, 97);
            this.baseButton11.Name = "baseButton11";
            this.baseButton11.Size = new System.Drawing.Size(132, 125);
            this.baseButton11.TabIndex = 0;
            this.baseButton11.Text = "Employees";
            this.baseButton11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.baseButton11.UseVisualStyleBackColor = false;
            this.baseButton11.Click += new System.EventHandler(this.baseButton11_Click);
            // 
            // baseButton12
            // 
            this.baseButton12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.baseButton12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseButton12.Image = ((System.Drawing.Image)(resources.GetObject("baseButton12.Image")));
            this.baseButton12.Location = new System.Drawing.Point(138, 234);
            this.baseButton12.Name = "baseButton12";
            this.baseButton12.Size = new System.Drawing.Size(132, 125);
            this.baseButton12.TabIndex = 2;
            this.baseButton12.Text = "Stock";
            this.baseButton12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.baseButton12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.baseButton12.UseVisualStyleBackColor = false;
            this.baseButton12.Click += new System.EventHandler(this.baseButton12_Click);
            // 
            // baseButton13
            // 
            this.baseButton13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.baseButton13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseButton13.Image = ((System.Drawing.Image)(resources.GetObject("baseButton13.Image")));
            this.baseButton13.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.baseButton13.Location = new System.Drawing.Point(137, 371);
            this.baseButton13.Name = "baseButton13";
            this.baseButton13.Size = new System.Drawing.Size(132, 125);
            this.baseButton13.TabIndex = 3;
            this.baseButton13.Text = "Order";
            this.baseButton13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.baseButton13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.baseButton13.UseVisualStyleBackColor = false;
            this.baseButton13.Click += new System.EventHandler(this.baseButton13_Click);
            // 
            // baseButton14
            // 
            this.baseButton14.BackColor = System.Drawing.SystemColors.Control;
            this.baseButton14.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.baseButton14.Location = new System.Drawing.Point(23, 626);
            this.baseButton14.Name = "baseButton14";
            this.baseButton14.Size = new System.Drawing.Size(129, 43);
            this.baseButton14.TabIndex = 4;
            this.baseButton14.Text = "Back";
            this.baseButton14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.baseButton14.UseVisualStyleBackColor = true;
            this.baseButton14.Click += new System.EventHandler(this.baseButton14_Click);
            // 
            // testLabelManager
            // 
            this.testLabelManager.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.testLabelManager.AutoSize = true;
            this.testLabelManager.BackColor = System.Drawing.Color.WhiteSmoke;
            this.testLabelManager.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testLabelManager.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.testLabelManager.Location = new System.Drawing.Point(140, 28);
            this.testLabelManager.Name = "testLabelManager";
            this.testLabelManager.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.testLabelManager.Size = new System.Drawing.Size(129, 29);
            this.testLabelManager.TabIndex = 5;
            this.testLabelManager.Text = "Select a database:";
            this.testLabelManager.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.Controls.Add(this.baseButton14);
            this.backgroundPanel.Controls.Add(this.testLabelManager);
            this.backgroundPanel.Controls.Add(this.baseButton13);
            this.backgroundPanel.Controls.Add(this.baseButton11);
            this.backgroundPanel.Controls.Add(this.baseButton12);
            this.backgroundPanel.Location = new System.Drawing.Point(60, 60);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(428, 697);
            this.backgroundPanel.TabIndex = 6;
            // 
            // ManagerOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 799);
            this.Controls.Add(this.backgroundPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "ManagerOverview";
            this.Text = "ManagerOverview";
            this.Load += new System.EventHandler(this.ManagerOverview_Load);
            this.Controls.SetChildIndex(this.backgroundPanel, 0);
            this.Controls.SetChildIndex(this.titleLabel, 0);
            this.backgroundPanel.ResumeLayout(false);
            this.backgroundPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StyleGuide.BaseButton1 baseButton11;
        private StyleGuide.BaseButton1 baseButton12;
        private StyleGuide.BaseButton1 baseButton13;
        private StyleGuide.BaseButton1 baseButton14;
        private System.Windows.Forms.Label testLabelManager;
        private System.Windows.Forms.Panel backgroundPanel;
    }
}