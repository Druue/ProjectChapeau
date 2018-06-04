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

        public void createEmployee(string firstname, string lastname, string jobrole, string password, string username)
        {
            var connection = openConnectionDB();
            var command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO Employee (Firstname,Lastname,JobRole,Password,Username) VALUES(" + firstname + "," + lastname + "," + jobrole + "," + password + "," + username + ")";
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void editEmployee(string firstname, string lastname, string jobrole, string password, string username)
        {
            var connection = openConnectionDB();
            var command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "UPDATE Emloyee SET Firstname = " + firstname + ",Lastname = " + lastname + ",JobRole = " + jobrole + ",Password =  " + password + ",Username = " + username + ";"; // UPDATE COMMANT
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void deleteEmployee(string name)
        {
            var connection = openConnectionDB();
            var command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "DELETE FROM Employee WHERE Firstname = '" + name + "' ";
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void addStock(string name)
        {
            var connection = openConnectionDB();
            var command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "UPDATE Menu SET Stock = Stock + 1; WHERE itemName = " + name + "";
            command.ExecuteNonQuery();
            connection.Close();
        }
    }

}
