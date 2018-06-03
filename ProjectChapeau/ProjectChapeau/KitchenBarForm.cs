using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauKitBarUI;
using Chapeau_Model;

namespace ProjectChapeau
{
    public partial class KitchenBarForm : Form
    {
        public KitchenBarForm()
        {
            InitializeComponent();
        }

        private void KitchenBarForm_Load(object sender, EventArgs e)
        {
            KitchenBarUI kitbar = new KitchenBarUI();
            DataTable orderList = kitbar.GetOrders();

            KitchenBarView.DataSource = orderList;
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
