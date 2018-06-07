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
            this.Employees_button = new System.Windows.Forms.Button();
            this.stock_button = new System.Windows.Forms.Button();
            this.orders_button = new System.Windows.Forms.Button();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Size = new System.Drawing.Size(750, 29);
            this.titleLabel.Text = "Management";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.back_button.Location = new System.Drawing.Point(151, 553);
            this.back_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(145, 51);
            this.back_button.TabIndex = 3;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Employees_button
            // 
            this.Employees_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Employees_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Employees_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees_button.Image = ((System.Drawing.Image)(resources.GetObject("Employees_button.Image")));
            this.Employees_button.Location = new System.Drawing.Point(305, 183);
            this.Employees_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Employees_button.Name = "Employees_button";
            this.Employees_button.Size = new System.Drawing.Size(132, 107);
            this.Employees_button.TabIndex = 0;
            this.Employees_button.Text = "Employees";
            this.Employees_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Employees_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Employees_button.UseVisualStyleBackColor = false;
            this.Employees_button.Click += new System.EventHandler(this.Employees_button_Click);
            // 
            // stock_button
            // 
            this.stock_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stock_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stock_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_button.Image = ((System.Drawing.Image)(resources.GetObject("stock_button.Image")));
            this.stock_button.Location = new System.Drawing.Point(305, 290);
            this.stock_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stock_button.Name = "stock_button";
            this.stock_button.Size = new System.Drawing.Size(132, 107);
            this.stock_button.TabIndex = 1;
            this.stock_button.Text = "Stock";
            this.stock_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stock_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.stock_button.UseVisualStyleBackColor = false;
            this.stock_button.Click += new System.EventHandler(this.stock_button_Click);
            // 
            // orders_button
            // 
            this.orders_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.orders_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.orders_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_button.Image = ((System.Drawing.Image)(resources.GetObject("orders_button.Image")));
            this.orders_button.Location = new System.Drawing.Point(305, 397);
            this.orders_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orders_button.Name = "orders_button";
            this.orders_button.Size = new System.Drawing.Size(132, 108);
            this.orders_button.TabIndex = 2;
            this.orders_button.Text = "Order";
            this.orders_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.orders_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.orders_button.UseVisualStyleBackColor = false;
            this.orders_button.Click += new System.EventHandler(this.orders_button_Click);
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.subtitleLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.subtitleLabel.Location = new System.Drawing.Point(109, 72);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.subtitleLabel.Size = new System.Drawing.Size(515, 570);
            this.subtitleLabel.TabIndex = 6;
            this.subtitleLabel.Text = "Select a database:";
            this.subtitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.subtitleLabel.Click += new System.EventHandler(this.textmanager_label_Click);
            // 
            // managerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 679);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.orders_button);
            this.Controls.Add(this.stock_button);
            this.Controls.Add(this.Employees_button);
            this.Controls.Add(this.back_button);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "managerForm";
            this.Text = "Chapeau";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.back_button, 0);
            this.Controls.SetChildIndex(this.Employees_button, 0);
            this.Controls.SetChildIndex(this.stock_button, 0);
            this.Controls.SetChildIndex(this.orders_button, 0);
            this.Controls.SetChildIndex(this.subtitleLabel, 0);
            this.Controls.SetChildIndex(this.titleLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button Employees_button;
        private System.Windows.Forms.Button stock_button;
        private System.Windows.Forms.Button orders_button;
        private System.Windows.Forms.Label subtitleLabel;
    }
}

