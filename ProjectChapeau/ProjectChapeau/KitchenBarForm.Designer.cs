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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitchenBarForm));
            this.panelKitchen = new System.Windows.Forms.Panel();
            this.KitchenBarView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKitchen = new System.Windows.Forms.Button();
            this.btnGetWait = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.KitchenBarView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelKitchen
            // 
            this.panelKitchen.BackColor = System.Drawing.Color.Transparent;
            this.panelKitchen.ForeColor = System.Drawing.SystemColors.Window;
            this.panelKitchen.Location = new System.Drawing.Point(175, 52);
            this.panelKitchen.Name = "panelKitchen";
            this.panelKitchen.Size = new System.Drawing.Size(671, 294);
            this.panelKitchen.TabIndex = 0;
            // 
            // KitchenBarView
            // 
            this.KitchenBarView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KitchenBarView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.KitchenBarView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KitchenBarView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.KitchenBarView.Location = new System.Drawing.Point(52, 52);
            this.KitchenBarView.Name = "KitchenBarView";
            this.KitchenBarView.Size = new System.Drawing.Size(925, 370);
            this.KitchenBarView.TabIndex = 1;
            this.KitchenBarView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(48, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orders";
            // 
            // btnKitchen
            // 
            this.btnKitchen.BackColor = System.Drawing.Color.Orange;
            this.btnKitchen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKitchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitchen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKitchen.Location = new System.Drawing.Point(785, 463);
            this.btnKitchen.Name = "btnKitchen";
            this.btnKitchen.Size = new System.Drawing.Size(192, 42);
            this.btnKitchen.TabIndex = 1;
            this.btnKitchen.Text = "Complete Order";
            this.btnKitchen.UseVisualStyleBackColor = false;
            this.btnKitchen.Click += new System.EventHandler(this.btnKitchen_Click);
            // 
            // btnGetWait
            // 
            this.btnGetWait.BackColor = System.Drawing.Color.Orange;
            this.btnGetWait.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGetWait.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetWait.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetWait.Location = new System.Drawing.Point(494, 462);
            this.btnGetWait.Name = "btnGetWait";
            this.btnGetWait.Size = new System.Drawing.Size(192, 43);
            this.btnGetWait.TabIndex = 2;
            this.btnGetWait.Text = "Call Waiter";
            this.btnGetWait.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // KitchenBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1031, 544);
            this.Controls.Add(this.KitchenBarView);
            this.Controls.Add(this.btnGetWait);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKitchen);
            this.Controls.Add(this.panelKitchen);
            this.Name = "KitchenBarForm";
            this.Text = "Kitchen Orders";
            this.Load += new System.EventHandler(this.KitchenBarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KitchenBarView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelKitchen;
        private System.Windows.Forms.Button btnKitchen;
        private System.Windows.Forms.Button btnGetWait;
        private System.Windows.Forms.DataGridView KitchenBarView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}