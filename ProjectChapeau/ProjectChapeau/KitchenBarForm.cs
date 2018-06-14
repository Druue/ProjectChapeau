using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            panelKitchen.BackColor = Color.FromArgb(230, Color.White);

            ListView orderTable = new ListView();
            orderTable.Height = 294; //671, 294
            orderTable.Width = 671;
            orderTable.View = View.Details;
            orderTable.BackColor = Color.Orange;
            orderTable.Scrollable = true;
            orderTable.GridLines = true;

            ColumnHeader orderId = new ColumnHeader();
           //orderId.BackColor = Color.Orange;
            orderId.Text = "Order Id";
            orderId.Name = "col1";
            orderId.Width = 134;
            orderTable.Columns.Add(orderId);

            ColumnHeader itemName = new ColumnHeader();
            itemName.Text = "Item Name";
            itemName.Name = "col2";
            itemName.Width = 134;
            orderTable.Columns.Add(itemName);

            ColumnHeader comments = new ColumnHeader();
            comments.Text = "Comments";
            comments.Name = "col4";
            comments.Width = 134;
            orderTable.Columns.Add(comments);

            ColumnHeader placedBy = new ColumnHeader();
            placedBy.Text = "PlacedBy";
            placedBy.Name = "col5";
            placedBy.Width = 134;
            orderTable.Columns.Add(placedBy);

            ColumnHeader orderTime = new ColumnHeader();
            orderTime.Text = "Order Time";
            orderTime.Name = "col6";
            orderTime.Width = 134;
            orderTable.Columns.Add(orderTime);

            foreach (var o in orderList)
            {
                string orderItem = o.item.Replace('_', ' ');
                string placedTime = o.orderTime.ToString("HH:mm");

                //orderTable.Add(o.orderId, orderItem, o.comments,o.PlacedBy, orderTime);

                ListViewItem orders = new ListViewItem(o.orderId.ToString());

                orders.SubItems.Add(o.item);
                orders.SubItems.Add(orderItem);
                orders.SubItems.Add(o.PlacedBy);
                orders.SubItems.Add(placedTime);

                orderTable.Items.Add(orders);
            }
            panelKitchen.Controls.Add(orderTable);
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
