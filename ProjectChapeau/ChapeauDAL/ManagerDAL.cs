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
        private SqlConnection openConnDB() //Made by Machelle
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(@"Data Source=tcp:194.171.20.101;Initial Catalog=Chapeau_1718_DB01;User ID=Chapeau_1718_grp01;Password=PTR6gURrRx");
                sqlconn.Open();

                return sqlconn;

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
            var connection = openConnDB();
            String query = "INSERT INTO Employee(Firstname, Lastname, JobRole, Password, Username) VALUES(@firstname,@lastname,@jobrole,@password,@username)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@firstname", firstname);
                command.Parameters.AddWithValue("@lastname", lastname);
                command.Parameters.AddWithValue("@jobrole", jobrole);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@username", username);

                int result = command.ExecuteNonQuery();

                // Check Error
                if (result < 0)
                    Console.WriteLine("Error inserting data into Database!");

                connection.Close();
            }
        }

        public void editEmployee(string firstname, string lastname, string jobrole, string password, string username)
        {
            var connection = openConnDB();

            String query = "UPDATE Employee SET JobRole =@jobrole,Password = @password,Username = @username WHERE firstName = @firstname and lastName = @lastname"; // UPDATE COMMANT

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@firstname", firstname);
                command.Parameters.AddWithValue("@lastname", lastname);
                command.Parameters.AddWithValue("@jobrole", jobrole);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@username", username);

                command.ExecuteNonQuery();             

                connection.Close();
            }
        }

        public void deleteEmployee(string name)
        {
            var connection = openConnDB();
            string query = "DELETE FROM Employee WHERE Firstname = @name";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@name", name);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void addStock(string name, int stock)
        {
            var connection = openConnDB();
            
            string query = "UPDATE Menu SET Stock = @stock WHERE itemName = @name";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@stock", stock +1);
                command.Parameters.AddWithValue("@name",name);
                command.ExecuteNonQuery();
                connection.Close();
            }            
        }
    }

}
