using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ChapeauModel;

namespace ChapeauDAL
{
    public class ManagerDAO
    {
        public SqlConnection openConnectionDB()
        {
            string host = "194.171.20.101";
            string db = "Chapeau_1718_DB01";
            string user = "projectdbgroupa3";
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
                SqlConnection sqlconn = null;
                Console.WriteLine(e.ToString());
                return sqlconn;
            }
        }


        private void closeConnDB(SqlConnection sqlconn)
        {
            sqlconn.Close();
        }


    }

}
