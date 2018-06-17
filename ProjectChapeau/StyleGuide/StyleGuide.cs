using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace StyleGuide
{
    public class BaseButton1 : Button
    {
            
        
         public BaseButton1()
        {
            this.SuspendLayout();
            // 
            // BaseButton
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "BaseButton";
            this.Size = new System.Drawing.Size(129, 43);
            this.TabIndex = 0;
            this.Text = "Back";
            this.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.UseVisualStyleBackColor = true;
            this.Click += new System.EventHandler(this.BaseButton_Click);
            this.ResumeLayout(false);

        }

        private void BaseButton_Click(object sender, EventArgs e)
        {

        }
    }

}
