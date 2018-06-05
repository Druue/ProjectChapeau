using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ChapeauUI;

namespace ProjectChapeau
{
    public partial class OrderingForm : Form
    {
        public OrderingForm()
        {
            InitializeComponent();
            MenuTypeComboBox.SelectedIndexChanged += (s, e) => MenuTypeComboBox_SelectedIndexChanged(s, e);
            MenuListView.SelectedIndexChanged += (s, e) => MenuListView_SelectedIndexChanged(s, e);
            OrdersCart.CellContentClick += (s, e) => OrderCartButtons_Click(s, e);
            OrdersCart.AllowUserToAddRows = false;
            OrdersCart.RowsAdded += (s, e) => OrdersCart_RowsAdded(s, e);
            OrdersCart.RowsRemoved += (s, e) => OrdersCart_RowsRemoved(s, e);
            PriceOverviewListView.ColumnWidthChanging += (s, e) => PriceOverviewListView_ColumnWidthChanged(s, e);
        }

        private void MenuTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderingUI.FillMenuList(MenuListView, MenuTypeComboBox);
        }

        private void MenuListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MenuListView.SelectedItems.Count > 0)
                AddToCartButton.Enabled = true;           
            else
                AddToCartButton.Enabled = false;
        }

        private void OrdersCart_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            OrderingUI.PriceOverviewUpdating(PriceOverviewListView,OrdersCart);
        }

        private void OrdersCart_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            OrderingUI.PriceOverviewUpdating(PriceOverviewListView, OrdersCart);           
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            int MenuItemID = int.Parse(MenuListView.SelectedItems[0].SubItems[1].Text);
            OrderingUI.AddCartItems(MenuItemID, OrdersCart);
        }

        private void OrderCartButtons_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == OrdersCart.Columns["CommentButtonColumn"].Index)
            {
                OrderingUI.ShowCommentForm(OrdersCart);
                
            }
            else if(e.ColumnIndex == OrdersCart.Columns["DeleteButtonColumn"].Index)
            {
                OrderingUI.DeleteRow(OrdersCart);
            }
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            DialogResult ContinueDialog = MessageBox.Show("Are you sure you want to place this order?", "Chapeau says", MessageBoxButtons.YesNo);
            if (ContinueDialog == DialogResult.Yes)
            {
               // OrderingDAL DBconnection = new OrderingDAL();
                //DBconnection.DB_InsertOrder(OrderingUI.SettingOrderFromCart(OrdersCart));
            }
        }

        private void PriceOverviewListView_ColumnWidthChanged(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = PriceOverviewListView.Columns[e.ColumnIndex].Width;
        }

        private void OrderingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
