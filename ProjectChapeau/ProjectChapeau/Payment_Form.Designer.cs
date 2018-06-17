namespace ProjectChapeau
{
    partial class Payment_Form
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
            this.payMethod1 = new System.Windows.Forms.RadioButton();
            this.payMethod2 = new System.Windows.Forms.RadioButton();
            this.payMethod3 = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.finishedPaymentBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // payMethod1
            // 
            this.payMethod1.AutoSize = true;
            this.payMethod1.Location = new System.Drawing.Point(63, 52);
            this.payMethod1.Name = "payMethod1";
            this.payMethod1.Size = new System.Drawing.Size(107, 21);
            this.payMethod1.TabIndex = 0;
            this.payMethod1.TabStop = true;
            this.payMethod1.Text = "payMethod1";
            this.payMethod1.UseVisualStyleBackColor = true;
            // 
            // payMethod2
            // 
            this.payMethod2.AutoSize = true;
            this.payMethod2.Location = new System.Drawing.Point(215, 52);
            this.payMethod2.Name = "payMethod2";
            this.payMethod2.Size = new System.Drawing.Size(107, 21);
            this.payMethod2.TabIndex = 1;
            this.payMethod2.TabStop = true;
            this.payMethod2.Text = "payMethod2";
            this.payMethod2.UseVisualStyleBackColor = true;
            // 
            // payMethod3
            // 
            this.payMethod3.AutoSize = true;
            this.payMethod3.Location = new System.Drawing.Point(372, 52);
            this.payMethod3.Name = "payMethod3";
            this.payMethod3.Size = new System.Drawing.Size(107, 21);
            this.payMethod3.TabIndex = 2;
            this.payMethod3.TabStop = true;
            this.payMethod3.Text = "payMethod3";
            this.payMethod3.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(157, 100);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(220, 269);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 439);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 22);
            this.textBox1.TabIndex = 4;
            // 
            // finishedPaymentBttn
            // 
            this.finishedPaymentBttn.Location = new System.Drawing.Point(157, 484);
            this.finishedPaymentBttn.Name = "finishedPaymentBttn";
            this.finishedPaymentBttn.Size = new System.Drawing.Size(220, 23);
            this.finishedPaymentBttn.TabIndex = 5;
            this.finishedPaymentBttn.Text = "Finalise Payment";
            this.finishedPaymentBttn.UseVisualStyleBackColor = true;
            // 
            // Payment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 554);
            this.Controls.Add(this.finishedPaymentBttn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.payMethod3);
            this.Controls.Add(this.payMethod2);
            this.Controls.Add(this.payMethod1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Payment_Form";
            this.Text = "Payment_Form";
            this.Load += new System.EventHandler(this.Payment_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton payMethod1;
        private System.Windows.Forms.RadioButton payMethod2;
        private System.Windows.Forms.RadioButton payMethod3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button finishedPaymentBttn;
    }
}