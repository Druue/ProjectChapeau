namespace StyleGuide
{
    partial class sideMenu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sideMenu));
            this.employeeSideMenuLabel = new System.Windows.Forms.Label();
            this.logOut = new System.Windows.Forms.Label();
            this.tableOverview = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.Label();
            this.LineLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeSideMenuLabel
            // 
            this.employeeSideMenuLabel.AutoSize = true;
            this.employeeSideMenuLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeSideMenuLabel.Location = new System.Drawing.Point(96, 43);
            this.employeeSideMenuLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeSideMenuLabel.Name = "employeeSideMenuLabel";
            this.employeeSideMenuLabel.Size = new System.Drawing.Size(149, 16);
            this.employeeSideMenuLabel.TabIndex = 0;
            this.employeeSideMenuLabel.Text = "Name of the employee";
            // 
            // logOut
            // 
            this.logOut.AutoSize = true;
            this.logOut.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.ForeColor = System.Drawing.Color.OrangeRed;
            this.logOut.Location = new System.Drawing.Point(36, 230);
            this.logOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(66, 19);
            this.logOut.TabIndex = 1;
            this.logOut.Text = "Log Out";
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // tableOverview
            // 
            this.tableOverview.AutoSize = true;
            this.tableOverview.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableOverview.ForeColor = System.Drawing.Color.OrangeRed;
            this.tableOverview.Location = new System.Drawing.Point(36, 148);
            this.tableOverview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tableOverview.Name = "tableOverview";
            this.tableOverview.Size = new System.Drawing.Size(116, 19);
            this.tableOverview.TabIndex = 2;
            this.tableOverview.Text = "Table Overview";
            this.tableOverview.Click += new System.EventHandler(this.tableOverview_Click);
            // 
            // settings
            // 
            this.settings.AutoSize = true;
            this.settings.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings.ForeColor = System.Drawing.Color.OrangeRed;
            this.settings.Location = new System.Drawing.Point(36, 315);
            this.settings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(67, 19);
            this.settings.TabIndex = 3;
            this.settings.Text = "Settings";
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // LineLabel
            // 
            this.LineLabel.AutoSize = true;
            this.LineLabel.Location = new System.Drawing.Point(-4, 93);
            this.LineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LineLabel.Name = "LineLabel";
            this.LineLabel.Size = new System.Drawing.Size(263, 22);
            this.LineLabel.TabIndex = 5;
            this.LineLabel.Text = "_______________________";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 71);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // sideMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LineLabel);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.tableOverview);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.employeeSideMenuLabel);
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "sideMenu";
            this.Size = new System.Drawing.Size(251, 545);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label employeeSideMenuLabel;
        protected System.Windows.Forms.Label logOut;
        protected System.Windows.Forms.Label tableOverview;
        protected System.Windows.Forms.Label settings;
        protected System.Windows.Forms.Label LineLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
