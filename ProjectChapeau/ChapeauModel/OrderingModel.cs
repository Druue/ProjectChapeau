using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauTestV2
{
    public class OrderingModel
    {
        public class Order
        {
            public int OrderID, TableID, EmployeeID;
            public double order_price;
            public bool order_PaidStatus;
            public List<Item> order_items;

            public Order()
            {

            }

            public Order(int OrderID, int TableID, int EmployeeID, double order_price)
            {
                this.OrderID = OrderID;
                this.TableID = TableID;
                this.EmployeeID = EmployeeID;
                this.order_price = order_price;
            }
        }

        public class Item
        {
            public int itemID;
            public string name;
            public decimal item_price;
            public string comment;
            public int quantity;
            public string MenuType;

            public Item()
            {

            }

            public Item(int itemID, int stock, string name, decimal item_price, string MenuType)
            {
                this.itemID = itemID;
                this.name = name;
                this.item_price = item_price;
                this.MenuType = MenuType;

            }
        }
    }


    public class DataGridViewNumericUpDownCell : DataGridViewTextBoxCell
    {
        public DataGridViewNumericUpDownCell()
        {

        }
    }
}

