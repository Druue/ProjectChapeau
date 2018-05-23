namespace ProjectChapeau
{
    partial class LoginForm
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
            this.login_panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // login_panel
            // 
            this.login_panel.Location = new System.Drawing.Point(303, 170);
            this.login_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(150, 81);
            this.login_panel.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 472);
            this.Controls.Add(this.login_panel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.Text = "Chapeau";
            this.Load += new System.EventHandler(this.LoginForm_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel login_panel;
    }
}

