namespace ProjectChapeau
{
    partial class KitchenBarForm
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
            this.panelKitchen = new System.Windows.Forms.Panel();
            this.btnKitchen = new System.Windows.Forms.Button();
            this.btnGetWait = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelKitchen
            // 
            this.panelKitchen.Location = new System.Drawing.Point(68, 33);
            this.panelKitchen.Name = "panelKitchen";
            this.panelKitchen.Size = new System.Drawing.Size(396, 252);
            this.panelKitchen.TabIndex = 0;
            // 
            // btnKitchen
            // 
            this.btnKitchen.Location = new System.Drawing.Point(304, 333);
            this.btnKitchen.Name = "btnKitchen";
            this.btnKitchen.Size = new System.Drawing.Size(192, 42);
            this.btnKitchen.TabIndex = 1;
            this.btnKitchen.Text = "Complete Order";
            this.btnKitchen.UseVisualStyleBackColor = true;
            // 
            // btnGetWait
            // 
            this.btnGetWait.Location = new System.Drawing.Point(81, 329);
            this.btnGetWait.Name = "btnGetWait";
            this.btnGetWait.Size = new System.Drawing.Size(154, 45);
            this.btnGetWait.TabIndex = 2;
            this.btnGetWait.Text = "Call Waiter";
            this.btnGetWait.UseVisualStyleBackColor = true;
            // 
            // KitchenBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetWait);
            this.Controls.Add(this.btnKitchen);
            this.Controls.Add(this.panelKitchen);
            this.Name = "KitchenBarForm";
            this.Text = "KitchenBarForm";
            this.Load += new System.EventHandler(this.KitchenBarForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelKitchen;
        private System.Windows.Forms.Button btnKitchen;
        private System.Windows.Forms.Button btnGetWait;
    }
}