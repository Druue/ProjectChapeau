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

        public static List<OrderingModel.Item> CallTableItemsDB(int tableId)
        {
            List<OrderingModel.Item> TableItemsList;
            TableItemsList = DBConnection.DB_getTableItems(tableId);

            return TableItemsList;
        }

        public static TableStatus getTableData(int tableId)
        {
            return DBConnection.DB_getTableData(tableId);

        }

        public static List<OrderingModel.Item> CallTableReceipt()
        {
            List<OrderingModel.Item> MenuItemsList;
            MenuItemsList = DBConnection.DB_getMenu();

            return MenuItemsList;
        }

        public static void ActionInsertOrdersDB(OrderingModel.Order NewOrder)
        {
            DBConnection.DB_InsertOrder(NewOrder);
        }

        public static string RepairName(string objectName)
        {
            objectName = objectName.Replace("_", " ");
            return objectName;
        }

        public static double columnMultiplier(double valueX, double valueY)
        {
            return valueX * valueY;
        }

    }
}
