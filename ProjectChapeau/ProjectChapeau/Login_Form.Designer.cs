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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btn_login = new System.Windows.Forms.Button();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.txtbox_username = new System.Windows.Forms.TextBox();
            this.btn_login_to_begin = new System.Windows.Forms.Button();
            this.login_panel = new System.Windows.Forms.Panel();
            this.login_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_login.FlatAppearance.BorderSize = 3;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(83, 141);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(95, 40);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txtbox_password
            // 
            this.txtbox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_password.Location = new System.Drawing.Point(34, 81);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(190, 27);
            this.txtbox_password.TabIndex = 1;
            this.txtbox_password.Text = "Password";
            // 
            // txtbox_username
            // 
            this.txtbox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_username.Location = new System.Drawing.Point(34, 39);
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.Size = new System.Drawing.Size(190, 27);
            this.txtbox_username.TabIndex = 0;
            this.txtbox_username.Text = "Firstname.Lastname";
            // 
            // btn_login_to_begin
            // 
            this.btn_login_to_begin.BackColor = System.Drawing.Color.Transparent;
            this.btn_login_to_begin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_login_to_begin.FlatAppearance.BorderSize = 3;
            this.btn_login_to_begin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login_to_begin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_to_begin.ForeColor = System.Drawing.Color.White;
            this.btn_login_to_begin.Location = new System.Drawing.Point(185, 442);
            this.btn_login_to_begin.Name = "btn_login_to_begin";
            this.btn_login_to_begin.Size = new System.Drawing.Size(190, 40);
            this.btn_login_to_begin.TabIndex = 1;
            this.btn_login_to_begin.Text = "Login to begin";
            this.btn_login_to_begin.UseVisualStyleBackColor = false;
            this.btn_login_to_begin.Click += new System.EventHandler(this.btn_login_to_begin_Click);
            // 
            // login_panel
            // 
            this.login_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.login_panel.BackColor = System.Drawing.Color.Transparent;
            this.login_panel.Controls.Add(this.txtbox_username);
            this.login_panel.Controls.Add(this.btn_login);
            this.login_panel.Controls.Add(this.txtbox_password);
            this.login_panel.Location = new System.Drawing.Point(156, 269);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(240, 213);
            this.login_panel.TabIndex = 3;
            this.login_panel.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(546, 799);
            this.Controls.Add(this.login_panel);
            this.Controls.Add(this.btn_login_to_begin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Chapeau";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.TextBox txtbox_username;
        private System.Windows.Forms.Button btn_login_to_begin;
        private System.Windows.Forms.Panel login_panel;
    }
}

