using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapeau_Logic;
using Chapeau_Model;
using System.Data;

namespace ChapeauKitBarUI
{
    public class KitchenBarUI
    {
        public DataTable GetOrders()
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

                orderTable.Rows.Add(o.orderId, orderItem, o.comments, orderTime);
            }
            //this is for the test commit
            return orderTable;
        }
    }
}
