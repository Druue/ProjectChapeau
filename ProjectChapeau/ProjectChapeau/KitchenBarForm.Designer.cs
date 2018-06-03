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
            this.label1 = new System.Windows.Forms.Label();
            this.KitchenBarView = new System.Windows.Forms.DataGridView();
            this.panelKitchen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KitchenBarView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelKitchen
            // 
            this.panelKitchen.Controls.Add(this.KitchenBarView);
            this.panelKitchen.Controls.Add(this.label1);
            this.panelKitchen.Location = new System.Drawing.Point(68, 33);
            this.panelKitchen.Name = "panelKitchen";
            this.panelKitchen.Size = new System.Drawing.Size(671, 294);
            this.panelKitchen.TabIndex = 0;
            // 
            // btnKitchen
            // 
            this.btnKitchen.Location = new System.Drawing.Point(547, 352);
            this.btnKitchen.Name = "btnKitchen";
            this.btnKitchen.Size = new System.Drawing.Size(192, 42);
            this.btnKitchen.TabIndex = 1;
            this.btnKitchen.Text = "Complete Order";
            this.btnKitchen.UseVisualStyleBackColor = true;
            this.btnKitchen.Click += new System.EventHandler(this.btnKitchen_Click);
            // 
            // btnGetWait
            // 
            this.btnGetWait.Location = new System.Drawing.Point(336, 352);
            this.btnGetWait.Name = "btnGetWait";
            this.btnGetWait.Size = new System.Drawing.Size(165, 43);
            this.btnGetWait.TabIndex = 2;
            this.btnGetWait.Text = "Call Waiter";
            this.btnGetWait.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orders";
            // 
            // KitchenBarView
            // 
            this.KitchenBarView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.KitchenBarView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KitchenBarView.Location = new System.Drawing.Point(3, 25);
            this.KitchenBarView.Name = "KitchenBarView";
            this.KitchenBarView.Size = new System.Drawing.Size(665, 266);
            this.KitchenBarView.TabIndex = 1;
            this.KitchenBarView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.panelKitchen.ResumeLayout(false);
            this.panelKitchen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KitchenBarView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelKitchen;
        private System.Windows.Forms.Button btnKitchen;
        private System.Windows.Forms.Button btnGetWait;
        private System.Windows.Forms.DataGridView KitchenBarView;
        private System.Windows.Forms.Label label1;
    }
}