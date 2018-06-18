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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment_Form));
            this.payMethod1 = new System.Windows.Forms.RadioButton();
            this.payMethod2 = new System.Windows.Forms.RadioButton();
            this.payMethod3 = new System.Windows.Forms.RadioButton();
            this.orderItemsPaymentlv = new System.Windows.Forms.ListView();
            this.CommentsTxt = new System.Windows.Forms.TextBox();
            this.FinishedPaymentBttn = new System.Windows.Forms.Button();
            this.orderDetailsPaymentlv = new System.Windows.Forms.ListView();
            this.TipInputnum = new System.Windows.Forms.NumericUpDown();
            this.CancelPaymentbttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TipInputnum)).BeginInit();
            this.SuspendLayout();
            // 
            // payMethod1
            // 
            this.payMethod1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("payMethod1.BackgroundImage")));
            this.payMethod1.Location = new System.Drawing.Point(32, 516);
            this.payMethod1.Name = "payMethod1";
            this.payMethod1.Size = new System.Drawing.Size(90, 70);
            this.payMethod1.TabIndex = 0;
            this.payMethod1.TabStop = true;
            this.payMethod1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.payMethod1.UseMnemonic = false;
            this.payMethod1.UseVisualStyleBackColor = true;
            // 
            // payMethod2
            // 
            this.payMethod2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("payMethod2.BackgroundImage")));
            this.payMethod2.Location = new System.Drawing.Point(204, 516);
            this.payMethod2.Name = "payMethod2";
            this.payMethod2.Size = new System.Drawing.Size(90, 70);
            this.payMethod2.TabIndex = 1;
            this.payMethod2.TabStop = true;
            this.payMethod2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.payMethod2.UseVisualStyleBackColor = true;
            // 
            // payMethod3
            // 
            this.payMethod3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("payMethod3.BackgroundImage")));
            this.payMethod3.Location = new System.Drawing.Point(360, 516);
            this.payMethod3.Name = "payMethod3";
            this.payMethod3.Size = new System.Drawing.Size(90, 70);
            this.payMethod3.TabIndex = 2;
            this.payMethod3.TabStop = true;
            this.payMethod3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.payMethod3.UseVisualStyleBackColor = true;
            // 
            // orderItemsPaymentlv
            // 
            this.orderItemsPaymentlv.Location = new System.Drawing.Point(32, 29);
            this.orderItemsPaymentlv.Name = "orderItemsPaymentlv";
            this.orderItemsPaymentlv.Size = new System.Drawing.Size(418, 156);
            this.orderItemsPaymentlv.TabIndex = 3;
            this.orderItemsPaymentlv.UseCompatibleStateImageBehavior = false;
            // 
            // CommentsTxt
            // 
            this.CommentsTxt.Location = new System.Drawing.Point(32, 314);
            this.CommentsTxt.Multiline = true;
            this.CommentsTxt.Name = "CommentsTxt";
            this.CommentsTxt.Size = new System.Drawing.Size(418, 83);
            this.CommentsTxt.TabIndex = 4;
            // 
            // FinishedPaymentBttn
            // 
            this.FinishedPaymentBttn.Location = new System.Drawing.Point(267, 639);
            this.FinishedPaymentBttn.Name = "FinishedPaymentBttn";
            this.FinishedPaymentBttn.Size = new System.Drawing.Size(183, 40);
            this.FinishedPaymentBttn.TabIndex = 5;
            this.FinishedPaymentBttn.Text = "Finalise Payment";
            this.FinishedPaymentBttn.UseVisualStyleBackColor = true;
            this.FinishedPaymentBttn.Click += new System.EventHandler(this.FinishedPaymentBttn_Click);
            // 
            // orderDetailsPaymentlv
            // 
            this.orderDetailsPaymentlv.Location = new System.Drawing.Point(32, 208);
            this.orderDetailsPaymentlv.Name = "orderDetailsPaymentlv";
            this.orderDetailsPaymentlv.Size = new System.Drawing.Size(418, 67);
            this.orderDetailsPaymentlv.TabIndex = 6;
            this.orderDetailsPaymentlv.UseCompatibleStateImageBehavior = false;
            // 
            // TipInputnum
            // 
            this.TipInputnum.Location = new System.Drawing.Point(187, 432);
            this.TipInputnum.Name = "TipInputnum";
            this.TipInputnum.Size = new System.Drawing.Size(120, 22);
            this.TipInputnum.TabIndex = 7;
            this.TipInputnum.ValueChanged += new System.EventHandler(this.TipInputnum_ValueChanged);
            // 
            // CancelPaymentbttn
            // 
            this.CancelPaymentbttn.Location = new System.Drawing.Point(32, 639);
            this.CancelPaymentbttn.Name = "CancelPaymentbttn";
            this.CancelPaymentbttn.Size = new System.Drawing.Size(183, 40);
            this.CancelPaymentbttn.TabIndex = 8;
            this.CancelPaymentbttn.Text = "Cancel Payment";
            this.CancelPaymentbttn.UseVisualStyleBackColor = true;
            this.CancelPaymentbttn.Click += new System.EventHandler(this.CancelPaymentbttn_Click);
            // 
            // Payment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 753);
            this.Controls.Add(this.CancelPaymentbttn);
            this.Controls.Add(this.TipInputnum);
            this.Controls.Add(this.orderDetailsPaymentlv);
            this.Controls.Add(this.FinishedPaymentBttn);
            this.Controls.Add(this.CommentsTxt);
            this.Controls.Add(this.orderItemsPaymentlv);
            this.Controls.Add(this.payMethod3);
            this.Controls.Add(this.payMethod2);
            this.Controls.Add(this.payMethod1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Payment_Form";
            this.Text = "Payment_Form";
            this.Load += new System.EventHandler(this.Payment_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TipInputnum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton payMethod1;
        private System.Windows.Forms.RadioButton payMethod2;
        private System.Windows.Forms.RadioButton payMethod3;
        private System.Windows.Forms.ListView orderItemsPaymentlv;
        private System.Windows.Forms.TextBox CommentsTxt;
        private System.Windows.Forms.Button FinishedPaymentBttn;
        private System.Windows.Forms.ListView orderDetailsPaymentlv;
        private System.Windows.Forms.NumericUpDown TipInputnum;
        private System.Windows.Forms.Button CancelPaymentbttn;
    }
}