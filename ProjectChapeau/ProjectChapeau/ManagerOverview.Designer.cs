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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(managerForm));
            this.back_button = new System.Windows.Forms.Button();
            this.management_label = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Employees_button = new System.Windows.Forms.Button();
            this.stock_button = new System.Windows.Forms.Button();
            this.orders_button = new System.Windows.Forms.Button();
            this.textmanager_label = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.back_button.Location = new System.Drawing.Point(132, 463);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(129, 43);
            this.back_button.TabIndex = 3;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // management_label
            // 
            this.management_label.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.management_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.management_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.management_label.Font = new System.Drawing.Font("Arial Narrow", 13.8F);
            this.management_label.Location = new System.Drawing.Point(0, 28);
            this.management_label.Name = "management_label";
            this.management_label.Size = new System.Drawing.Size(667, 72);
            this.management_label.TabIndex = 4;
            this.management_label.Text = "Management";
            this.management_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.DarkOrange;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(667, 28);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
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
            this.Employees_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Employees_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees_button.Image = ((System.Drawing.Image)(resources.GetObject("Employees_button.Image")));
            this.Employees_button.Location = new System.Drawing.Point(271, 154);
            this.Employees_button.Name = "Employees_button";
            this.Employees_button.Size = new System.Drawing.Size(117, 90);
            this.Employees_button.TabIndex = 0;
            this.Employees_button.Text = "Employees";
            this.Employees_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Employees_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Employees_button.UseVisualStyleBackColor = false;
            this.Employees_button.Click += new System.EventHandler(this.Employees_button_Click);
            // 
            // stock_button
            // 
            this.stock_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stock_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_button.Image = ((System.Drawing.Image)(resources.GetObject("stock_button.Image")));
            this.stock_button.Location = new System.Drawing.Point(271, 244);
            this.stock_button.Name = "stock_button";
            this.stock_button.Size = new System.Drawing.Size(117, 90);
            this.stock_button.TabIndex = 1;
            this.stock_button.Text = "Stock";
            this.stock_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stock_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.stock_button.UseVisualStyleBackColor = false;
            // 
            // orders_button
            // 
            this.orders_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.orders_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_button.Image = ((System.Drawing.Image)(resources.GetObject("orders_button.Image")));
            this.orders_button.Location = new System.Drawing.Point(271, 334);
            this.orders_button.Name = "orders_button";
            this.orders_button.Size = new System.Drawing.Size(117, 91);
            this.orders_button.TabIndex = 2;
            this.orders_button.Text = "Order";
            this.orders_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.orders_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.orders_button.UseVisualStyleBackColor = false;
            // 
            // textmanager_label
            // 
            this.textmanager_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.textmanager_label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textmanager_label.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.textmanager_label.Location = new System.Drawing.Point(0, 100);
            this.textmanager_label.Name = "textmanager_label";
            this.textmanager_label.Size = new System.Drawing.Size(667, 17);
            this.textmanager_label.TabIndex = 6;
            this.textmanager_label.Text = "Select a database:";
            this.textmanager_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.textmanager_label.Click += new System.EventHandler(this.textmanager_label_Click);
            // 
            // managerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 572);
            this.Controls.Add(this.textmanager_label);
            this.Controls.Add(this.orders_button);
            this.Controls.Add(this.management_label);
            this.Controls.Add(this.stock_button);
            this.Controls.Add(this.Employees_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "managerForm";
            this.Text = "Chapeau";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label management_label;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button Employees_button;
        private System.Windows.Forms.Button stock_button;
        private System.Windows.Forms.Button orders_button;
        private System.Windows.Forms.Label textmanager_label;
    }
}

