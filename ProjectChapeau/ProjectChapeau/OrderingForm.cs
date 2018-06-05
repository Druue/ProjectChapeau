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
    public partial class OrderingForm : Form
    {
        public OrderingForm()
        {
            InitializeComponent();
            FillMenuList();
            MenuTypeComboBox.SelectedIndexChanged += (s, e) => MenuTypeComboBox_SelectedIndexChanged(s, e);
            MenuListView.SelectedIndexChanged += (s, e) => MenuListView_SelectedIndexChanged(s, e);
            OrdersCart.CellContentClick += (s, e) => OrderCartButtons_Click(s, e);
            OrdersCart.AllowUserToAddRows = false;
            OrdersCart.RowsAdded += (s, e) => OrdersCart_RowsAdded(s, e);
            OrdersCart.RowsRemoved += (s, e) => OrdersCart_RowsRemoved(s, e);
            PriceOverviewListView.ColumnWidthChanging += (s, e) => PriceOverviewListView_ColumnWidthChanged(s, e);
        }

        public void FillMenuList()
        {
            MenuListView.HideSelection = false;
            MenuListView.Items.Clear();
            List<OrderingModel.Item> MenuItemsList = new List<OrderingModel.Item>();
            MenuItemsList = OrderingLogic.CallMenuListDB();
            
            foreach (OrderingModel.Item MenuItem in MenuItemsList)
            {
                ListViewItem ListViewMenuItem = new ListViewItem(MenuItem.name);
                ListViewMenuItem.ImageIndex = MenuItem.itemID;
                ListViewMenuItem.SubItems.Add(MenuItem.itemID.ToString());
                MenuListView.Items.Add(ListViewMenuItem);
            }

        }

        private void AddCartItems(int MenuItemID)
        {
            List<OrderingModel.Item> MenuList = OrderingLogic.CallMenuListDB();

            foreach (OrderingModel.Item item in MenuList)
            {

                if (item.itemID == MenuItemID)
                {
                    if ((CheckItemPresent(MenuItemID)))
                    {
                        int QuantityValue = int.Parse(OrdersCart.Rows[SearchCorrectRow(MenuItemID)].Cells["QuantityColumn"].Value.ToString());
                        OrdersCart.Rows[SearchCorrectRow(MenuItemID)].Cells["QuantityColumn"].Value = QuantityValue + 1;
                        break;
                    }
                    else
                    {
                        OrdersCart.Rows.Add("Comment", item.name, "X", 1, item.itemID, item.item_price);
                        break;
                    }

                }

            }
        }

        private int SearchCorrectRow(int MenuItemID)
        {
            foreach (DataGridViewRow CartRow in OrdersCart.Rows)
            {
                if (CartRow.Cells["ItemID"].Value.Equals(MenuItemID))
                {
                    return CartRow.Index;
                }

            }

            return 0;
        }

        private bool CheckItemPresent(int MenuItemID)
        {
            foreach (DataGridViewRow CartRow in OrdersCart.Rows)
            {
                if (CartRow.Cells[4].Value.Equals(MenuItemID) && CartRow.Cells[4].Value != null)
                {
                    return true;
                }
            }
            return false;
        }

        private void ShowCommentForm()
        {
            Form CommentsForm = new Form();

            TextBox CommentsTextBox = new TextBox();
            CommentsTextBox.Location = new System.Drawing.Point(40, 40);
            CommentsTextBox.Width = 200;
            CommentsTextBox.Height = 160;
            CommentsTextBox.Multiline = true;
            if (OrdersCart.CurrentRow.Cells["CommentHidden"].Value != null)
            {
                if (string.IsNullOrWhiteSpace(OrdersCart.CurrentRow.Cells["CommentHidden"].Value.ToString()))
                {
                    CommentsTextBox.Text = "";
                }
                else
                {
                    CommentsTextBox.Text = OrdersCart.CurrentRow.Cells["CommentHidden"].Value.ToString();
                }
            }

            CommentsForm.Controls.Add(CommentsTextBox);

            Button AddCommentsButton = new Button();
            AddCommentsButton.Text = "Add comments to the Item";
            AddCommentsButton.Location = new System.Drawing.Point(60, 210);
            AddCommentsButton.Width = 160;
            AddCommentsButton.Height = 30;
            CommentsForm.Controls.Add(AddCommentsButton);

            AddCommentsButton.Click += (s, e) => {
                OrdersCart.CurrentRow.Cells["CommentHidden"].Value = CommentsTextBox.Text.ToString();
                CommentsForm.Close();

            };

            CommentsForm.ShowDialog();
        }

        private void DeleteRow()
        {
            OrdersCart.Rows.Remove(OrdersCart.CurrentRow);
        }

        private List<OrderingModel.Item> SettingOrderFromCart()
        {
            List<OrderingModel.Item> OrderItemsList = new List<OrderingModel.Item>();

            foreach (DataGridViewRow row in OrdersCart.Rows)
            {
                OrderingModel.Item OrderItem = new OrderingModel.Item();
                OrderItem.itemID = int.Parse(row.Cells["ItemID"].Value.ToString());
                OrderItem.comment = row.Cells["CommentHidden"].Value.ToString();
                OrderItem.quantity = int.Parse(row.Cells["QuantityColumn"].Value.ToString());

                OrderItemsList.Add(OrderItem);
            }

            return OrderItemsList;
        }

        private void PriceOverviewUpdating()
        {
            PriceOverviewListView.Items.Clear();

            foreach (DataGridViewRow row in OrdersCart.Rows)
            {
                ListViewItem PriceRow = new ListViewItem(row.Cells["ItemNameColumn"].Value.ToString());
                PriceRow.SubItems.Add("....................");
                PriceRow.SubItems.Add(row.Cells["PriceColumn"].Value.ToString());

                PriceOverviewListView.Items.Add(PriceRow);
            }
        }



        private void MenuTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillMenuList();
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
            PriceOverviewUpdating();
        }

        private void OrdersCart_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            PriceOverviewUpdating();           
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            int MenuItemID = int.Parse(MenuListView.SelectedItems[0].SubItems[1].Text);
            AddCartItems(MenuItemID);
        }

        private void OrderCartButtons_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == OrdersCart.Columns["CommentButtonColumn"].Index)
            {
                ShowCommentForm();
                
            }
            else if(e.ColumnIndex == OrdersCart.Columns["DeleteButtonColumn"].Index)
            {
                DeleteRow();
            }
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            DialogResult ContinueDialog = MessageBox.Show("Are you sure you want to place this order?", "Chapeau says", MessageBoxButtons.YesNo);
            if (ContinueDialog == DialogResult.Yes)
            {
                OrderingLogic.ActionInsertOrdersDB(SettingOrderFromCart());
            }
        }

        private void PriceOverviewListView_ColumnWidthChanged(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = PriceOverviewListView.Columns[e.ColumnIndex].Width;
        }
    }
}
