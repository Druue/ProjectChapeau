﻿using System;
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
        private SqlConnection OpenConnDB() //Machelle
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

        private void CloseConnDB(SqlConnection sqlconn) //Machelle
        {
            sqlconn.Close();
        }

        public List<OrderItems> OrderItemsDAO(int orderID) //Sophie - Complete
        {
            SqlConnection conn = OpenConnDB();

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT ItemName, Price, Vat, [Orders].[OrderId], [OrderItems].[ItemId], completed = 1 " +
                      "FROM Menu, OrderItems, Orders " +
                      "WHERE [Orders].[OrderId] = [OrderItems].[OrderId] AND [Menu].[ItemId] = [OrderItems].[ItemId] " +
                      "AND [Orders].[OrderId] = @orderId");
            String sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("@orderId", orderID); //prevents sql injection
            SqlDataReader reader = command.ExecuteReader();

            OrderItems item;
            List<OrderItems> orderItems = new List<OrderItems>();
            while (reader.Read())
            {
                item = new OrderItems(reader["ItemName"].ToString(), 0, double.Parse(reader["Price"].ToString()),
                                                 double.Parse(reader["Vat"].ToString()));

                orderItems.Add(item);                               
            }

            CloseConnDB(conn);

            return orderItems;
        }

        public void PaymentDAO(Payment payment) //Sophie
        {
            SqlConnection conn = OpenConnDB();
            List<OrderItems> orderItems = new List<OrderItems>();

            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT into Payment (OrderId, TotalPrice, EmployeeId, Tip, PaymentMethod, BasePrice, VATPrice, Comments, TimePayed)" +
                      "VALUES (@OrderId, @TotalPrice, @EmployeeId, @Tip, @PaymentMethod, @BasePrice, @Vat, @Comments, @TimePayed)");
            String sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("@OrderId", payment.OrderId);
            command.Parameters.AddWithValue("@TotalPrice", payment.TotalPrice);
            command.Parameters.AddWithValue("@EmployeeId", payment.EmployeeId);
            command.Parameters.AddWithValue("@Tip", payment.Tip);
            command.Parameters.AddWithValue("@PaymentMethod", payment.PaymentMethod.ToString());
            command.Parameters.AddWithValue("@BasePrice", payment.InitialPrice);
            command.Parameters.AddWithValue("@Vat", payment.Vat);
            command.Parameters.AddWithValue("@Comments", payment.Comments);
            command.Parameters.AddWithValue("@TimePayed", payment.TimePayed);

            command.ExecuteNonQuery();
            CloseConnDB(conn);
        }

        public List<TableTop> TableTopDAO() //Machelle
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

        public ChapeauModel.Employee LoginDAO(string username, string password) //Machelle
        {            
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

        public List<ChapeauModel.Employee> EmployeeDAO() //Machelle
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

        
        public List<ChapeauModel.Order> OrderDAO() //Elizabeth
        {
            SqlConnection conn = OpenConnDB();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT Orders.OrderId, OrderItems.Comment, Orders.TableId, Employee.Firstname, Orders.OrderTime, ItemName, completed, MenuType FROM  Orders, OrderItems, Menu, Employee WHERE  Orders.OrderId = OrderItems.OrderId AND menu.ItemId = OrderItems.ItemId AND Employee.EmployeeId=Orders.EmployeeId AND Orders.completed = 0");

            String sql = sb.ToString();
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();

            List<ChapeauModel.Order> orderList = new List<ChapeauModel.Order>();


            while (reader.Read())
            {
                ChapeauModel.Order order = new ChapeauModel.Order();

                int type = (int)reader["MenuType"];

                if (type == 1 || type == 2)
                {
                    order.orderId = (int)reader["OrderId"];
                    order.comments = reader["Comment"].ToString();
                    order.tableId = (int)reader["TableId"];
                    order.orderTime = (DateTime)reader["OrderTime"];
                    order.item = reader["ItemName"].ToString();
                    order.PlacedBy = reader["Firstname"].ToString();
                    order.completed = (int)reader["completed"];


                    orderList.Add(order);
                }

            }

            return orderList;
        }

        public List<ChapeauModel.Order> DrinkOrderDAO() //Elizabeth
        {
            SqlConnection conn = OpenConnDB();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT Orders.OrderId, OrderItems.Comment, Orders.TableId, Employee.Firstname, Orders.OrderTime, ItemName, completed, MenuType FROM  Orders, OrderItems, Menu, Employee WHERE  Orders.OrderId = OrderItems.OrderId AND menu.ItemId = OrderItems.ItemId AND Employee.EmployeeId=Orders.EmployeeId AND Orders.completed = 0");

            String sql = sb.ToString();
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();

            List<ChapeauModel.Order> drinkList = new List<ChapeauModel.Order>();


            while (reader.Read())
            {
                ChapeauModel.Order order = new ChapeauModel.Order();


                int type = (int)reader["MenuType"];
                if (type == 3)
                {
                    order.orderId = (int)reader["OrderId"];
                    order.comments = reader["Comment"].ToString();
                    order.tableId = (int)reader["TableId"];
                    order.orderTime = (DateTime)reader["OrderTime"];
                    order.item = reader["ItemName"].ToString();
                    order.PlacedBy = reader["Firstname"].ToString();
                    int completed = (int)reader["completed"];

                    drinkList.Add(order);
                }

            }

            return drinkList;
        }

        public void UpdateOrderDAO(ChapeauModel.Order selectedOrder) //Elizabeth
        {
            SqlConnection conn = OpenConnDB();
            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE Orders SET completed = @complete WHERE OrderId = @orderId");

            String sql = sb.ToString();
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("@complete", selectedOrder.completed);
            command.Parameters.AddWithValue("@orderId", selectedOrder.orderId);
            command.ExecuteNonQuery();
        }
    }
}