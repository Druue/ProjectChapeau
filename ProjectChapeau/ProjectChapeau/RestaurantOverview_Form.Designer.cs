namespace ProjectChapeau
{
    partial class RestaurantOverview_Form
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
            this.flowlaypnl_table_overview_uneven = new System.Windows.Forms.FlowLayoutPanel();
            this.flowlaypnl_table_overview_even = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_logoff = new System.Windows.Forms.Button();
            this.lbl_loggedinEmployee = new System.Windows.Forms.Label();
            this.pnl_topbar = new System.Windows.Forms.Panel();
            this.pnl_topbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowlaypnl_table_overview_uneven
            // 
            this.flowlaypnl_table_overview_uneven.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowlaypnl_table_overview_uneven.Location = new System.Drawing.Point(12, 53);
            this.flowlaypnl_table_overview_uneven.Name = "flowlaypnl_table_overview_uneven";
            this.flowlaypnl_table_overview_uneven.Size = new System.Drawing.Size(163, 522);
            this.flowlaypnl_table_overview_uneven.TabIndex = 0;
            // 
            // flowlaypnl_table_overview_even
            // 
            this.flowlaypnl_table_overview_even.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowlaypnl_table_overview_even.Location = new System.Drawing.Point(181, 53);
            this.flowlaypnl_table_overview_even.Name = "flowlaypnl_table_overview_even";
            this.flowlaypnl_table_overview_even.Size = new System.Drawing.Size(163, 522);
            this.flowlaypnl_table_overview_even.TabIndex = 1;
            // 
            // btn_logoff
            // 
            this.btn_logoff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logoff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(100)))));
            this.btn_logoff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_logoff.FlatAppearance.BorderSize = 0;
            this.btn_logoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logoff.Location = new System.Drawing.Point(302, 0);
            this.btn_logoff.Name = "btn_logoff";
            this.btn_logoff.Size = new System.Drawing.Size(79, 35);
            this.btn_logoff.TabIndex = 2;
            this.btn_logoff.Text = "Log off";
            this.btn_logoff.UseVisualStyleBackColor = false;
            this.btn_logoff.Click += new System.EventHandler(this.btn_logoff_Click);
            // 
            // lbl_loggedinEmployee
            // 
            this.lbl_loggedinEmployee.AutoSize = true;
            this.lbl_loggedinEmployee.Location = new System.Drawing.Point(81, 9);
            this.lbl_loggedinEmployee.Name = "lbl_loggedinEmployee";
            this.lbl_loggedinEmployee.Size = new System.Drawing.Size(24, 17);
            this.lbl_loggedinEmployee.TabIndex = 3;
            this.lbl_loggedinEmployee.Text = "    ";
            // 
            // pnl_topbar
            // 
            this.pnl_topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnl_topbar.Controls.Add(this.btn_logoff);
            this.pnl_topbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_topbar.ForeColor = System.Drawing.Color.White;
            this.pnl_topbar.Location = new System.Drawing.Point(-1, 0);
            this.pnl_topbar.Name = "pnl_topbar";
            this.pnl_topbar.Size = new System.Drawing.Size(384, 37);
            this.pnl_topbar.TabIndex = 4;
            // 
            // RestaurantOverview_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 676);
            this.Controls.Add(this.pnl_topbar);
            this.Controls.Add(this.lbl_loggedinEmployee);
            this.Controls.Add(this.flowlaypnl_table_overview_even);
            this.Controls.Add(this.flowlaypnl_table_overview_uneven);
            this.Name = "RestaurantOverview_Form";
            this.Text = "RestaurantOverview_Form";
            this.pnl_topbar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowlaypnl_table_overview_uneven;
        private System.Windows.Forms.FlowLayoutPanel flowlaypnl_table_overview_even;
        private System.Windows.Forms.Button btn_logoff;
        private System.Windows.Forms.Label lbl_loggedinEmployee;
        private System.Windows.Forms.Panel pnl_topbar;
    }
}