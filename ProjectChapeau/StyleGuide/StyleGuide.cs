using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace StyleGuide
{
        public class BaseButton : Button
        {
            public BaseButton()
            {
                FlatStyle = FlatStyle.Flat;
                ForeColor = Color.FromArgb(192, 64, 0);
                Size = new Size(100, 30);
                UseVisualStyleBackColor = true;
                
            }

        }
    }
}
