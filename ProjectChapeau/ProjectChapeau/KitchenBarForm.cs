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
using Chapeau_Logic;

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
            ChapeauLogic logic = new ChapeauLogic();
            List<ChapeauModel.Order> orderList = logic.showOrders();

            DataTable orderTable = new DataTable();
            orderTable.Columns.Add("Order Number");
            orderTable.Columns.Add("Item Name");
            orderTable.Columns.Add("Comments");
            orderTable.Columns.Add("Placed By");
            orderTable.Columns.Add("Time");

            foreach (var o in orderList)
            {
                string orderItem = o.item.Replace('_', ' ');
                string orderTime = o.orderTime.ToString("HH:mm");

                orderTable.Rows.Add(o.orderId, orderItem, o.comments,o.PlacedBy, orderTime);
            }
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //KitchenBarUI kitbar = new KitchenBarUI();
            KitchenBarForm_Load(sender, e);

            //KitchenBarView.DataSource = orderList;
        }
    }
}
