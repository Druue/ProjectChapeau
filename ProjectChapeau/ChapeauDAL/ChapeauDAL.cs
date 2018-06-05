using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Chapeau_Model;


namespace Chapeau_DAL
{
    public class ChapeauDAL
    {
        private SqlConnection OpenConnDB() //Made by Machelle
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(@"Data Source=tcp:194.171.20.101;
                                                            Initial Catalog=Chapeau_1718_DB01;
                                                            User ID=Chapeau_1718_grp01;
                                                            Password=PTR6gURrRx");

                //Data Source = 194.171.20.101; Initial Catalog = Chapeau_1718_DB01; Persist Security Info = True; User ID = Chapeau_1718_grp01; Password = ***********
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

        private void CloseConnDB(SqlConnection sqlconn) //Made by Machelle
        {
            sqlconn.Close();
        }

        public List<OrderItems> OrderItemsDAO(int itemId, int orderId)
        {
            SqlConnection conn = OpenConnDB();
            List<OrderItems> orderItems = new List<OrderItems>();

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT ItemName, ItemId, Price, Vat FROM Menu " +
                      "WHERE ItemId = @itemId AND OrderId = @orderId FROM OrderItems" /*+
                      "something about getting the right orderid"*/);
            String sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("@itemId", itemId); //prevents sql injection
            command.Parameters.AddWithValue("@orderId", orderId); //prevents sql injection
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                OrderItems item = new OrderItems(reader["ItemName"].ToString(), /*Int32.Parse(reader["ItemId"].ToString()),*/
                                                        Int32.Parse(reader["Price"].ToString()), double.Parse(reader["Vat"].ToString()));
                orderItems.Add(item);
            }

            CloseConnDB(conn);

            return orderItems;
        }

        public void PaymentDAO(Payment payment)
        {
            SqlConnection conn = OpenConnDB();
            List<OrderItems> orderItems = new List<OrderItems>();

            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT STATEMENT");
            String sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                
            }

            CloseConnDB(conn);
        }

        public List<ChapeauModel.TableTop> TableTopDAO()
        {
            SqlConnection conn = OpenConnDB();
            List<ChapeauModel.TableTop> table_list = new List<ChapeauModel.TableTop>();


            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT TableId, Seats, TableStatus FROM TableTop");
            String sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ChapeauModel.TableTop table = new ChapeauModel.TableTop(Int32.Parse(reader["TableId"].ToString()), Int32.Parse(reader["Seats"].ToString()), reader["TableStatus"].ToString());
                table_list.Add(table);
            }

            CloseConnDB(conn);

            return table_list;
        }

        public ChapeauModel.Employee LoginDAO(string username, string password) // HIER WAS JE GEBLEVEN!
        {
            ChapeauModel.Employee loginTry = null;

            SqlConnection conn = OpenConnDB();
            
            string query = $"SELECT EmployeeId, Username, Password, JobRole " +
              $"FROM Employee " +
              $"WHERE Username = @username AND Password = @password";


            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@username", username); //this is to prevent sql injection!!
            command.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = command.ExecuteReader();

            ChapeauModel.Employee LoginEmployee = null;

            
            if (reader.Read())
            {
                // dit zou je in een methode kunnen stoppen om weer opnieuw te gebruiken (geef reader mee als parameter), voor bijvoorbeeld het ophalen van een lijst.
                int employeeId = reader.GetInt32(0);
                string firstname = reader.GetString(1);
                string lastname = reader.GetString(2);
                string loginPassword = reader.GetString(3);
                JobRole role = (JobRole)reader.GetInt32(4);
                string loginUsername = reader.GetString(5);

                LoginEmployee = new ChapeauModel.Employee(employeeId, firstname, lastname, loginPassword, role, loginUsername);

            }

            conn.Close();
            return LoginEmployee;
        }

        public List<ChapeauModel.Employee> EmployeeDAO() //Made by Machelle
        {

            SqlConnection conn = OpenConnDB();
            List<ChapeauModel.Employee> employee_list = new List<ChapeauModel.Employee>();


            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT EmployeeId, Firstname, Lastname, Password, JobRole, Username FROM Employee");
            String sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ChapeauModel.Employee employee = new ChapeauModel.Employee(Int32.Parse(reader["EmployeeId"].ToString()), reader["Firstname"].ToString(), reader["Lastname"].ToString(), reader["Password"].ToString(), (JobRole)reader["JobRole"], reader["Username"].ToString());
                employee_list.Add(employee);
            }

            CloseConnDB(conn);

            return employee_list;
        }

        public List<ChapeauModel.Order> OrderDAO()
        {
            SqlConnection conn = OpenConnDB();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT Orders.OrderId, Orders.Comments, Orders.TableId, Orders.OrderTime, ItemName FROM  Orders, OrderItems, Menu WHERE  Orders.OrderId = OrderItems.OrderId AND menu.ItemId = OrderItems.ItemId");
            
            String sql = sb.ToString();
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();

            List<ChapeauModel.Order> orderList = new List<ChapeauModel.Order>();

            while (reader.Read())
            {
                ChapeauModel.Order order = new ChapeauModel.Order();
                order.orderId = (int)reader["OrderId"];
                order.item = reader["ItemName"].ToString();
                order.comments = reader["Comments"].ToString();
                order.tableId = (int)reader["TableId"];
                order.orderTime = (DateTime)reader["OrderTime"];

                orderList.Add(order);
            }

            return orderList;
        }

    }
}