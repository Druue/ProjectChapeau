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

        private JobRole jobrole;

        public KitchenBarForm(JobRole job)
        {
            InitializeComponent();

            jobrole = job;
        }

        private void KitchenBarForm_Load(object sender, EventArgs e)
        {

            BackgroundImageLayout = ImageLayout.Stretch;
            WindowState = FormWindowState.Maximized;
            panelKitchen.BackColor = Color.FromArgb(230, Color.White);

            if (jobrole == JobRole.Kitchen)
            {
                lblOrder.Text = "Orders";
                this.Text = "Kitchen Orders";
            }
            else
            {
                lblOrder.Text = "Drink Orders";
                this.Text = "Bar Orders";
            }

            //listview
            ListView orderTable = new ListView();
            orderTable.Name = "orderTable";
            orderTable.Height = panelKitchen.Width; 
            orderTable.Width = panelKitchen.Width;
            orderTable.View = View.Details;
            orderTable.Font = new Font("Arial", 20, FontStyle.Regular);
            orderTable.Scrollable = true;
            orderTable.GridLines = false;
            orderTable.FullRowSelect = true;
            orderTable.MultiSelect = true;
            orderTable.HideSelection = false;

            panelKitchen.Controls.Add(orderTable);

            //timer
            Timer timerKitchenBar = new Timer();
            timerKitchenBar.Interval = 3000;
            timerKitchenBar.Enabled = true;
            timerKitchenBar.Tick += new EventHandler((s, ev) => timer1_Tick(s, ev, orderTable)); ;
            timerKitchenBar.Start();
        }


        private void btnKitchen_Click(object sender, EventArgs e)
        {
            ListView orderTable = panelKitchen.Controls.Find("orderTable", true).First() as ListView;
            ListView.SelectedListViewItemCollection selectedOrders = orderTable.SelectedItems;

            ChapeauModel.Order selectedOrder = new ChapeauModel.Order();
            ChapeauLogic logic = new ChapeauLogic();

            foreach(ListViewItem o in selectedOrders)
            {
                ListViewItem.ListViewSubItemCollection order = o.SubItems;
                selectedOrder.orderId = Int32.Parse(order[0].Text);
                selectedOrder.item = order[1].Text;
                selectedOrder.comments = order[2].Text;
                selectedOrder.PlacedBy = order[3].Text;
                selectedOrder.orderTime = DateTime.Parse(order[4].Text.ToString());
                selectedOrder.completed = Int32.Parse(order[5].Text);

                logic.FlipCompleteStatus(selectedOrder);

                o.Remove();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void fillOrderTable(ListView orderTable)
        {
            ChapeauLogic logic = new ChapeauLogic();
            List<ChapeauModel.Order> orderList;

            if (jobrole == JobRole.Kitchen)
            {   
                orderList = logic.showOrders();
            }
            else
            {
                orderList = logic.showDrinkOrders();
            }


            ColumnHeader orderId = new ColumnHeader();
            orderId.Text = "Order Id";
            orderId.Name = "col1";
            orderId.Width = panelKitchen.Width / 5;
            orderTable.Columns.Add(orderId);

            ColumnHeader itemName = new ColumnHeader();
            itemName.Text = "Item Name";
            itemName.Name = "col2";
            itemName.Width = panelKitchen.Width / 5;
            orderTable.Columns.Add(itemName);

            ColumnHeader comments = new ColumnHeader();
            comments.Text = "Comments";
            comments.Name = "col4";
            comments.Width = panelKitchen.Width / 5;
            orderTable.Columns.Add(comments);

            ColumnHeader placedBy = new ColumnHeader();
            placedBy.Text = "PlacedBy";
            placedBy.Name = "col5";
            placedBy.Width = panelKitchen.Width / 5;
            orderTable.Columns.Add(placedBy);

            ColumnHeader orderTime = new ColumnHeader();
            orderTime.Text = "Order Time";
            orderTime.Name = "col6";
            orderTime.Width = panelKitchen.Width / 5;
            orderTable.Columns.Add(orderTime);

            foreach (var o in orderList)
            {
                string orderItem = o.item.Replace('_', ' ');
                string placedTime = o.orderTime.ToString("HH:mm");

                ListViewItem orders = new ListViewItem(o.orderId.ToString());

                orders.SubItems.Add(orderItem);
                orders.SubItems.Add(o.comments);
                orders.SubItems.Add(o.PlacedBy);
                orders.SubItems.Add(placedTime);
                orders.SubItems.Add(o.completed.ToString());
                orders.SubItems.Add(o.tableId.ToString());

                orderTable.Items.Add(orders);
            }
        }


        private void timer1_Tick(object sender, EventArgs e, ListView orderTable)
        {
            orderTable.Clear();
            this.fillOrderTable(orderTable);
        }


        private void logOffBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetWait_Click(object sender, EventArgs e)
        {

            DialogResult dialog = (MessageBox.Show("Waitstaff is notified!", "Notification Sent", MessageBoxButtons.OK));
        }
    }
}
