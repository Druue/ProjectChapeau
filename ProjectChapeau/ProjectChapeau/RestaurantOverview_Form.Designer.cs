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
            // RestaurantOverview_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 587);
            this.Controls.Add(this.flowlaypnl_table_overview_even);
            this.Controls.Add(this.flowlaypnl_table_overview_uneven);
            this.Name = "RestaurantOverview_Form";
            this.Text = "RestaurantOverview_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowlaypnl_table_overview_uneven;
        private System.Windows.Forms.FlowLayoutPanel flowlaypnl_table_overview_even;
    }
}