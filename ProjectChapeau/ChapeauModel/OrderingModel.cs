using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauTest
{
    public class OrderingModel
    {

            public class Order
            {
                public int OrderID, TableID, EmployeeID;
                public double order_price, order_vat;
                public bool order_PaidStatus;
                
                public Order(int OrderID, int TableID, int EmployeeID, double order_price, double order_vat)
                {
                    this.OrderID = OrderID;
                    this.TableID = TableID;
                    this.EmployeeID = EmployeeID;
                    this.order_price = order_price;
                    this.order_vat = order_vat;
                }               
            }

            public class Item
            {
                public int itemID, stock;
                public string name;
                public double item_price, item_vat;
            

                public Item(int itemID, int stock, string name, double item_price, double item_vat)
                {
                    this.itemID = itemID;
                    this.stock = stock;
                    this.name = name;               
                    this.item_price = item_price;
                    this.item_vat = item_vat;

                }
        }
        
    }
}
