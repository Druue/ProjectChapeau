namespace ProjectChapeau
{
    partial class Form1
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
            this.MarianneWasHere = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // MarianneWasHere
            // 
            this.MarianneWasHere.AutoSize = true;
            this.MarianneWasHere.Location = new System.Drawing.Point(469, 171);
            this.MarianneWasHere.Name = "MarianneWasHere";
            this.MarianneWasHere.Size = new System.Drawing.Size(148, 21);
            this.MarianneWasHere.TabIndex = 0;
            this.MarianneWasHere.Text = "MarianneWasHere";
            this.MarianneWasHere.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MarianneWasHere);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox MarianneWasHere;
    }
}

