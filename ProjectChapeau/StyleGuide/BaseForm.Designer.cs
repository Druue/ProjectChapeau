namespace StyleGuide
{
    partial class BaseForm
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
        protected void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.titleLabel = new System.Windows.Forms.Label();
            this.sideMenu1 = new StyleGuide.sideMenu();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.DarkOrange;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(807, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(33, 24);
            this.toolStripMenuItem1.Text = "|||";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.titleLabel.Location = new System.Drawing.Point(0, 28);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.titleLabel.Size = new System.Drawing.Size(807, 29);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "label1";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sideMenu1
            // 
            this.sideMenu1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideMenu1.Location = new System.Drawing.Point(0, 32);
            this.sideMenu1.Margin = new System.Windows.Forms.Padding(4);
            this.sideMenu1.Name = "sideMenu1";
            this.sideMenu1.Size = new System.Drawing.Size(251, 545);
            this.sideMenu1.TabIndex = 2;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(807, 605);
            this.Controls.Add(this.sideMenu1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Arial", 10.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        protected System.Windows.Forms.Label titleLabel;
        private sideMenu sideMenu1;
    }
}