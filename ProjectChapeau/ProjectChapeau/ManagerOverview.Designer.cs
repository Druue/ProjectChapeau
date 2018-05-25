namespace ProjectChapeau
{
    partial class managerForm
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
            this.back_button = new System.Windows.Forms.Button();
            this.management_label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Employees_button = new System.Windows.Forms.Button();
            this.stock_button = new System.Windows.Forms.Button();
            this.orders_button = new System.Windows.Forms.Button();
            this.textmanager_label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(192, 469);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 3;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // management_label
            // 
            this.management_label.AutoSize = true;
            this.management_label.Location = new System.Drawing.Point(335, 11);
            this.management_label.Name = "management_label";
            this.management_label.Size = new System.Drawing.Size(90, 17);
            this.management_label.TabIndex = 4;
            this.management_label.Text = "Management";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(33, 24);
            this.toolStripMenuItem1.Text = "|||";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Employees_button
            // 
            this.Employees_button.Location = new System.Drawing.Point(338, 185);
            this.Employees_button.Name = "Employees_button";
            this.Employees_button.Size = new System.Drawing.Size(75, 23);
            this.Employees_button.TabIndex = 0;
            this.Employees_button.Text = "Employees";
            this.Employees_button.UseVisualStyleBackColor = true;
            this.Employees_button.Click += new System.EventHandler(this.Employees_button_Click);
            // 
            // stock_button
            // 
            this.stock_button.Location = new System.Drawing.Point(338, 270);
            this.stock_button.Name = "stock_button";
            this.stock_button.Size = new System.Drawing.Size(75, 23);
            this.stock_button.TabIndex = 1;
            this.stock_button.Text = "Stock";
            this.stock_button.UseVisualStyleBackColor = true;
            // 
            // orders_button
            // 
            this.orders_button.Location = new System.Drawing.Point(338, 354);
            this.orders_button.Name = "orders_button";
            this.orders_button.Size = new System.Drawing.Size(75, 24);
            this.orders_button.TabIndex = 2;
            this.orders_button.Text = "Order";
            this.orders_button.UseVisualStyleBackColor = true;
            // 
            // textmanager_label
            // 
            this.textmanager_label.AutoSize = true;
            this.textmanager_label.Location = new System.Drawing.Point(316, 111);
            this.textmanager_label.Name = "textmanager_label";
            this.textmanager_label.Size = new System.Drawing.Size(122, 17);
            this.textmanager_label.TabIndex = 6;
            this.textmanager_label.Text = "Select a database";
            // 
            // managerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 592);
            this.Controls.Add(this.textmanager_label);
            this.Controls.Add(this.orders_button);
            this.Controls.Add(this.management_label);
            this.Controls.Add(this.stock_button);
            this.Controls.Add(this.Employees_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "managerForm";
            this.Text = "Chapeau";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label management_label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button Employees_button;
        private System.Windows.Forms.Button stock_button;
        private System.Windows.Forms.Button orders_button;
        private System.Windows.Forms.Label textmanager_label;
    }
}

