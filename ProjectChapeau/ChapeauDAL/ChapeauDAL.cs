﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ChapeauModel;


namespace Chapeau_DAL
{
    public class ChapeauDAL
    {
        private SqlConnection openConnDB() //Made by Machelle
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

        private void closeConnDB(SqlConnection sqlconn) //Made by Machelle
        {
            sqlconn.Close();
        }
        public List<TableTop> TableTopDAO()
        {
            SqlConnection conn = openConnDB();
            List<TableTop> table_list = new List<TableTop>();


            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT TableId, Seats, TableStatus FROM TableTop");
            String sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                TableTop table = new TableTop(Int32.Parse(reader["TableId"].ToString()), Int32.Parse(reader["Seats"].ToString()), reader["TableStatus"].ToString());
                table_list.Add(table);
            }

            closeConnDB(conn);

            return table_list;
        }

        public Employee LoginTry(string username, string password) // HIER WAS JE GEBLEVEN!
        {
            Employee loginTry = null;

            SqlConnection conn = openConnDB();

            string query = $"SELECT EmployeeId, Username, Password, JobRole" +
              $"FROM Employee" +
              $"WHERE Username = @username, Password = @password";


            String sql = query.ToString();

            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();

            Employee LoginEmployee = null;



            while (reader.Read())
            {
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
        public List<Employee> EmployeeDAO() //Made by Machelle
        {

            SqlConnection conn = openConnDB();
            List<Employee> employee_list = new List<Employee>();


            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT EmployeeId, Firstname, Lastname, Password, JobRole, Username FROM Employee");
            String sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Employee employee = new Employee(Int32.Parse(reader["EmployeeId"].ToString()), reader["Firstname"].ToString(), reader["Lastname"].ToString(), reader["Password"].ToString(), (JobRole)reader["JobRole"], reader["Username"].ToString());
                employee_list.Add(employee);
            }

            closeConnDB(conn);

            return employee_list;
        }

        public List<Order> OrderDAO()
        {
            SqlConnection conn = openConnDB();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT Orders.OrderId, Orders.Comments, Orders.TableId, Orders.OrderTime, ItemName FROM  Orders, OrderItems, Menu WHERE  Orders.OrderId = OrderItems.OrderId AND menu.ItemId = OrderItems.ItemId");

            //sb.Append("SELECT Orders.OrderId, Orders.Comments, Orders.TableId, Orders.OrderTime, ItemName");
            //sb.Append("FROM Orders, OrderItems, Menu");
            //sb.Append("WHERE Orders.OrderId = OrderItems.OrderId AND menu.ItemId = OrderItems.ItemId");

            String sql = sb.ToString();
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();

            List<Order> orderList = new List<Order>();

            //int lastOrderId = -1;
            while (reader.Read())
            {
                ChapeauModel.Order order = new Order();
                order.orderId = (int)reader["OrderId"];
                order.item = reader["ItemName"].ToString();
                order.comments = reader["Comments"].ToString();
                order.tableId = (int)reader["TableId"];
                order.orderTime = (DateTime)reader["OrderTime"];

                orderList.Add(order);
                /* Only update order details if order number changes or first time
                if (lastOrderId != (int)reader["OrderId"])
                {
                    Order order = new Order();
                    order.orderId = (int)reader["OrderId"];
                    order.comments = reader["Comments"].ToString();
                    order.tableId = (int)reader["TableId"];
                    order.orderTime = (DateTime)reader["OrderTime"];
                    //order.orderId = (int)reader["OrderId"];

                
                    orderList.Add(order);

                }

                lastOrderId = (int)reader["OrderId"];

                // Add all items belonging to order
                orderList.Last().items.Add(reader["ItemName"].ToString());*/
            }

            return orderList;
        }

    }
}