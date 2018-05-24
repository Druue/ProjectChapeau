using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauTest
{
    public partial class OrderingForm : Form
    {
        public OrderingForm()
        {
            InitializeComponent();
        }

        private void ChapeauForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(OrderingUI.OrderMenuInterface(20,20));
        }
    }
}
