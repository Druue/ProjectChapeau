using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapeau_Model;
using Chapeau_DAL;

namespace Chapeau_Logic
{
    public class OrderingLogic
    {
        private static OrderingDAL DBConnection = new OrderingDAL();

        public static List<OrderingModel.Item> CallMenuListDB()
        {
            List<OrderingModel.Item> MenuItemsList;
            MenuItemsList = DBConnection.DB_getMenu();

            return MenuItemsList;
        }

        public static void ActionInsertOrdersDB(List<OrderingModel.Item> OrderItemsList)
        {
            DBConnection.DB_InsertOrder(OrderItemsList);
        }
    }
}
