using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StyleGuide
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            sideMenu.Visible = false;   
        }

        protected void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (sideMenu.Visible == false)
            {
                sideMenu.Visible = true;
            }
            else
            {
                sideMenu.Visible = false;
            }
        }
    }
}
