using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using System.Windows.Forms;
using Chapeau_DAL;
using Chapeau_Model;

namespace Chapeau_DAL
{
    public class OrderingDAL
    {
        private SqlConnection OpenConnectionDB()
        {
            string host = "194.171.20.101";
            string db = "Chapeau_1718_DB01";
            string user = "Chapeau_1718_grp01";
            string password = "PTR6gURrRx";
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = host;
                builder.UserID = user;
                builder.Password = password;
                builder.InitialCatalog = db;
                SqlConnection connection = new SqlConnection(builder.ConnectionString);

                connection.Open();
                return connection;
            }
            catch (SqlException e)
            {
                SqlConnection connection = null;
                Console.WriteLine(e.ToString());
                return connection;
            }
        }

        public List<OrderingModel.Item> DB_getMenu()
        {
            SqlConnection connection = OpenConnectionDB();
            List<OrderingModel.Item> MenuItemsList = new List<OrderingModel.Item>();
            string sqlQuery = "SELECT ItemId, ItemName, Price, stock, MenuType, subMenuType FROM Menu";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                OrderingModel.Item Item = new OrderingModel.Item();
                Item.itemID = (int)reader["ItemId"];
                Item.stock = (int)reader["stock"];
                Item.Name = (string)reader["ItemName"];
                Item.itemPrice = (decimal)reader["Price"];
                Item.MenuType = (MenuType)reader["MenuType"];
                Item.SubMenuType = (SubMenuType)reader["SubMenuType"];
                MenuItemsList.Add(Item);
            }
            reader.Close();
            connection.Close();
            return MenuItemsList;
        }


        public List<OrderingModel.Item> DB_getTableItems(int TableId)
        {
            SqlConnection connection = OpenConnectionDB();
            List<OrderingModel.Item> TableItemsList = new List<OrderingModel.Item>();
            string sqlQuery = "SELECT ItemId FROM OrderItems WHERE OrderId = (SELECT MAX(OrderId) FROM Orders WHERE TableId =" + TableId + " )";

            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = command.ExecuteReader();



            while (reader.Read())
            {
                OrderingModel.Item TableListItem = new OrderingModel.Item();
                TableListItem.itemID = (int)reader["ItemId"];
                foreach (OrderingModel.Item menuItem in DB_getMenu())
                {
                    if (menuItem.itemID == TableListItem.itemID)
                    {
                        TableItemsList.Add(menuItem);
                    }
                }

            }
            reader.Close();
            connection.Close();
            return TableItemsList;
        }

        public void DB_InsertOrder(OrderingModel.Order NewOrder, int tableId, int employeeId)
        {
                using (SqlCommand cmd =
                    new SqlCommand("INSERT INTO Orders ([OrderTime], [TableId], [EmployeeId], [completed]) VALUES(@OrderTime, @TableId, @EmployeeId, 0)", OpenConnectionDB()))
                {
                    cmd.Parameters.AddWithValue("@OrderTime", DateTime.Now);
                    cmd.Parameters.AddWithValue("@TableId", tableId);
                    cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                int rows = cmd.ExecuteNonQuery();

                }

            using (SqlCommand cmd =
                     new SqlCommand("UPDATE TableTop SET TableStatus = 1 WHERE TableId = " + tableId, OpenConnectionDB()))
            {
                int rows = cmd.ExecuteNonQuery();
            }


            foreach (OrderingModel.Item item in NewOrder.OrderItems)
                {
                    using (SqlCommand cmd =
                        new SqlCommand("INSERT INTO OrderItems ([ItemId], [Comment]) VALUES(@ItemId, @Comment)", OpenConnectionDB()))
                    {
                        cmd.Parameters.AddWithValue("@ItemId", item.itemID);
                        cmd.Parameters.AddWithValue("@Comment", item.comment);
                        int rows = cmd.ExecuteNonQuery();
                    }
                }

                foreach (OrderingModel.Item item in NewOrder.OrderItems)
                {
                    using (SqlCommand cmd =
                           new SqlCommand("UPDATE Menu SET stock = (SELECT (stock - " + item.quantity + ")) WHERE stock = " + item.itemID, OpenConnectionDB()))
                    {
                        int rows = cmd.ExecuteNonQuery();
                    }
                }

            }

        public void DB_DeleteOrder(int tableId)
        {
            using (SqlCommand cmd =
                           new SqlCommand("UPDATE TableTop SET TableStatus = 0 WHERE TableId = " + tableId, OpenConnectionDB()))
            {
                int rows = cmd.ExecuteNonQuery();
            }

            using (SqlCommand command = new SqlCommand("DELETE FROM OrderItems WHERE OrderId = (SELECT MAX(OrderId) FROM Orders WHERE TableId = " + tableId + ")", OpenConnectionDB()))
            {
                command.ExecuteNonQuery();
            }

        }

        public DateTime DB_GetOrderTime(int TableId)
        {
            SqlConnection connection = OpenConnectionDB();
            string sqlQuery = "SELECT OrderTime FROM Orders WHERE TableId = " + TableId;
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = command.ExecuteReader();

            DateTime OrderTime = new DateTime();

            while (reader.Read())
            {
                OrderTime = (DateTime)reader["OrderTime"];
            }
            reader.Close();
            connection.Close();

            return OrderTime;
        }

        public bool DB_GetOrderStatus(int OrderId)
        {
            SqlConnection connection = OpenConnectionDB();
            string sqlQuery = "SELECT completed FROM Orders WHERE OrderId = " + OrderId;
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = command.ExecuteReader();


            return false;

        }


        public int DB_GetOrderId(int TableId)
        {
            SqlConnection connection = OpenConnectionDB();
            string sqlQuery = "SELECT OrderId FROM Orders WHERE TableId = " + TableId;
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = command.ExecuteReader();

            int OrderId = 0;

            while (reader.Read())
            {
                OrderId += (int)reader["OrderId"];
            }
            reader.Close();
            connection.Close();

            return OrderId;

        }


    }
}
