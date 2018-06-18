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

        public List<OrderItems> OrderItemsDAO(int orderID) //Sophie - Complete(?)
        {
            SqlConnection conn = OpenConnDB();

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT ItemName, Price, Vat, [Orders].[OrderId], [OrderItems].[ItemId], completed " +
                      "FROM Menu, OrderItems, Orders " +
                      "WHERE [Orders].[OrderId] = [OrderItems].[OrderId] AND [Menu].[ItemId] = [OrderItems].[ItemId] AND completed = 1 " +
                      "AND [Orders].[OrderId] = @orderId");
            String sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("@orderId", orderID); //prevents sql injection
            SqlDataReader reader = command.ExecuteReader();

            OrderItems item;
            List<OrderItems> orderItems = new List<OrderItems>();
            while (reader.Read())
            {
                item = new OrderItems(reader["ItemName"].ToString(), 1, double.Parse(reader["Price"].ToString()),
                                                 double.Parse(reader["Vat"].ToString()));

                if (!orderItems.Contains(item))
                {
                    orderItems.Add(item);
                }

                else
                {
                    for (int i = 0; i < orderItems.Count; i++)
                    {
                        if (orderItems[i].ItemName == item.ItemName)
                        {
                            orderItems[i].Quantity++;
                        }
                    }
                }
            }

            CloseConnDB(conn);

            return orderItems;
        }

        public void PaymentDAO(Payment payment)
        {
            SqlConnection conn = OpenConnDB();
            List<OrderItems> orderItems = new List<OrderItems>();

            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT into Payment (EmployeedId,  VATPrice, Tip, BasePrice, TotalPrice, Comments, PaymentMethod, TimePayed)" +
                      "VALUES (@EmployeeId, @Vat, @Tip, @InitialPrice, @TotalPrice, @Comments, @PaymentMethod, @TimePayed)");
            String sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("@EmployeeId", payment.EmployeeId);
            command.Parameters.AddWithValue("@Vat", payment.Vat);
            command.Parameters.AddWithValue("@Tip", payment.Tip);
            command.Parameters.AddWithValue("@InitialPrice", payment.InitialPrice);
            command.Parameters.AddWithValue("@TotalPrice", payment.TotalPrice);
            command.Parameters.AddWithValue("@Comments", payment.Comments);
            command.Parameters.AddWithValue("@PaymentMethod", payment.PaymentMethod);
            command.Parameters.AddWithValue("@TimePayed", payment.TimePayed);

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected == 0)
            {

            }
            else
            {

            }

            CloseConnDB(conn);
        }

        public List<TableTop> TableTopDAO()
        {
            SqlConnection conn = OpenConnDB();
            List<TableTop> table_list = new List<TableTop>();


            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT TableId, Seats, TableStatus FROM TableTop");
            String sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                TableTop table = new TableTop(Int32.Parse(reader["TableId"].ToString()),
                    Int32.Parse(reader["Seats"].ToString()), (TableStatus)reader["TableStatus"]);
                table_list.Add(table);
            }

            CloseConnDB(conn);

            return table_list;
        }

        public ChapeauModel.Employee LoginDAO(string username, string password) //Made by Machelle
        {
            ChapeauModel.Employee loginTry = null;

            SqlConnection conn = OpenConnDB();

            string query = $"SELECT EmployeeId, Username, Password, JobRole, Firstname, Lastname " +
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
                string loginUsername = reader.GetString(1);
                string loginPassword = reader.GetString(2);
                JobRole role = (JobRole)reader.GetInt32(3);
                string firstname = reader.GetString(4);
                string lastname = reader.GetString(5);

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

        public List<ChapeauModel.Order> orderListPerTableOrderedRecent(int tableId) //Made by Machelle (for displaying the status of the most recent order)
        {
            SqlConnection conn = OpenConnDB();

            string query = $"SELECT Orders.OrderId, Orders.TableId, Orders.OrderTime, Orders.OrderStatus " +
            $"FROM Orders " +
            $"WHERE Orders.TableId = @tableId" + 
            $"ORDER BY Orders.OrderTime ASC";

            SqlCommand command = new SqlCommand(query, conn);

            SqlDataReader reader = command.ExecuteReader();

            List<ChapeauModel.Order> orderListRecent = null;
            ChapeauModel.Order order;


            if (reader.Read())
            {
                // dit zou je in een methode kunnen stoppen om weer opnieuw te gebruiken (geef reader mee als parameter), voor bijvoorbeeld het ophalen van een lijst.
                int orderid = reader.GetInt32(0);
                int tableid = reader.GetInt32(1);
                DateTime ordertime = reader.GetDateTime(2);
                int orderstatus = reader.GetInt32(3);


               order = new ChapeauModel.Order(orderid, tableid, ordertime, orderstatus);
                orderListRecent.Add(order);
            }

            conn.Close();
            return orderListRecent;
        }

        public List<ChapeauModel.Order> OrderDAO()
        {
            SqlConnection conn = OpenConnDB();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT Orders.OrderId, OrderItems.Comment, Orders.TableId, Employee.Firstname, Orders.OrderTime, ItemName, completed FROM  Orders, OrderItems, Menu, Employee WHERE  Orders.OrderId = OrderItems.OrderId AND menu.ItemId = OrderItems.ItemId AND Employee.EmployeeId=Orders.EmployeeId");

            String sql = sb.ToString();
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();

            List<ChapeauModel.Order> orderList = new List<ChapeauModel.Order>();


            while (reader.Read())
            {
                bool completed = (bool)reader["completed"];
                if (completed == false)
                {
                    ChapeauModel.Order order = new ChapeauModel.Order();
                    order.orderId = (int)reader["OrderId"];
                    order.comments = reader["Comment"].ToString();
                    order.tableId = (int)reader["TableId"];
                    order.orderTime = (DateTime)reader["OrderTime"];
                    order.item = reader["ItemName"].ToString();
                    order.PlacedBy = reader["Firstname"].ToString();


                    orderList.Add(order);
                }

            }

            return orderList;
        }

        public void UpdateOrderDAO(ChapeauModel.Order selectedOrder)
        {
            SqlConnection conn = OpenConnDB();
            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE Orders SET completed = @complete WHERE OrderId = @orderId");

            String sql = sb.ToString();
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("@complete", selectedOrder.completed);
            command.Parameters.AddWithValue("@orderId", selectedOrder.orderId);
            SqlDataReader reader = command.ExecuteReader();
        }
    }
}