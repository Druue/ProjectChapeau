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
        public Button BaseButton;        
        
        public void InitializeComponent()
        {
            this.BaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BaseButton
            // 
            this.BaseButton.BackColor = System.Drawing.SystemColors.Control;
            this.BaseButton.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.BaseButton.Location = new System.Drawing.Point(0, 0);
            this.BaseButton.Name = "BaseButton";
            this.BaseButton.Size = new System.Drawing.Size(129, 43);
            this.BaseButton.TabIndex = 0;
            this.BaseButton.Text = "Back";
            this.BaseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BaseButton.UseVisualStyleBackColor = true;
            // 
            // BaseButton1
            // 
            this.BaseButton.BackColor = System.Drawing.SystemColors.Control;
            this.BaseButton.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.BaseButton.Location = new System.Drawing.Point(0, 0);
            this.BaseButton.Name = "BaseButton";
            this.BaseButton.Size = new System.Drawing.Size(129, 43);
            this.BaseButton.TabIndex = 0;
            this.BaseButton.Text = "Back";
            this.BaseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BaseButton.UseVisualStyleBackColor = true;
            // 
        }
    }

}
