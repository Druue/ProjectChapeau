using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChapeauTestV2
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
            string sqlQuery = "SELECT ItemId, ItemName, Price, stock, MenuType FROM Menu";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                OrderingModel.Item Item = new OrderingModel.Item((int)reader["ItemId"], (int)reader["stock"],
                    (string)reader["ItemName"], (decimal)reader["Price"], (string)reader["MenuType"]);
                MenuItemsList.Add(Item);
            }
            reader.Close();
            connection.Close();
            return MenuItemsList;
        }

        public void DB_InsertOrder(List<OrderingModel.Item> OrderItemsList)
        {
            try
            {
                string time = DateTime.Now.ToShortTimeString().ToString();
                string date = DateTime.Now.ToShortDateString();
                string datetime = time + " " + date;
                // wquery to select from specific columns

                using (SqlCommand cmd =
                    new SqlCommand("INSERT INTO Orders VALUES(" +
                        "@OrderId, @OrderTime)", OpenConnectionDB()))
                {
                    cmd.Parameters.AddWithValue("@OrderId", "mysql_insert_id() + 1");
                    cmd.Parameters.AddWithValue("@OrderTime", datetime);

                    int rows = cmd.ExecuteNonQuery();

                }

                using (SqlCommand cmd =
                    new SqlCommand("INSERT INTO OrderItems VALUES(" +
                        "@OrderId, @ItemId, @Comment)", OpenConnectionDB()))
                {

                    foreach (OrderingModel.Item item in OrderItemsList)
                    {
                        cmd.Parameters.AddWithValue("@OrderId", "mysql_insert_id() + 1");
                        cmd.Parameters.AddWithValue("@ItemId", item.itemID);
                        cmd.Parameters.AddWithValue("@Comment", item.comment);

                    }

                    int rows = cmd.ExecuteNonQuery();
                
                }
                
            foreach (OrderingModel.Item item in OrderItemsList){

            using (SqlCommand cmd =
                   new SqlCommand("UPDATE Menu SET stock = @stock WHERE ID = " + item.itemID, OpenConnectionDB()))
                    {
                        cmd.Parameters.AddWithValue("@stock", "[stock - " + item.quantity + "]");
                        int rows = cmd.ExecuteNonQuery();
                    }
                }               
                OpenConnectionDB().Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }

        }
    }
}
