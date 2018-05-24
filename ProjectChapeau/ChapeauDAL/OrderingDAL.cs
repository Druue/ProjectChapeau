using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ChapeauTest
{
    class OrderingDAL
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
            string sqlQuery = "SELECT ItemId, ItemName, Price, Vat, stock, MenuType FROM Menu";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                OrderingModel.Item Item = new OrderingModel.Item((int)reader["ItemId"], (int)reader["stock"], 
                    (string)reader["name"], (double)reader["Price"], (double)reader["Vat"]); 
            }
            reader.Close();
            connection.Close();
            return MenuItemsList;
        }


    }
}
