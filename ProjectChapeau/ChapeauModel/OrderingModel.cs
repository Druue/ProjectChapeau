using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

namespace Chapeau_Model
{
    public class OrderingModel
    {
        public class Order
        {
            public int orderID, tableID, employeeID;
            public double orderPrice;
            public bool orderPaidStatus;

            public Order()
            {

            }

            public Order(int orderID, int tableID, int employeeID, double orderPrice)
            {
                this.orderID = orderID;
                this.tableID = tableID;
                this.employeeID = employeeID;
                this.orderPrice = orderPrice;
            }

            public List<Item> OrderItems;
        }

        public class Item
        {
            public int itemID;
            protected string name;
            public decimal itemPrice;
            public string comment;
            public int stock;
            public int quantity;
            protected MenuType menuType;

            public string Name
            {
                get { return name; }
                set
                {
                    name = value;
                    name.Replace("_", " ");
                }
            }

            public MenuType MenuType
            {
                get { return this.menuType; }
                set
                {
                    menuType = value;
                }
            }

            public Item()
            {
                this.comment = "";
            }

        }
    }


    //public class DataGridViewNumericUpDownCell : DataGridViewTextBoxCell
   // {
        //public DataGridViewNumericUpDownCell()
       // {

        //}
   // }
}

