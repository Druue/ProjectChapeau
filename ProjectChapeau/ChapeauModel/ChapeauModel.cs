using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class TableTop //made by Machelle
    {
        int TableId;
        int Seats;
        string TableStatus;

        public TableTop()
        {
            //an empty constructor is nessecary to use an empty object (NULL)
        }

        public TableTop(int id, int seats, string status)
        {
            this.TableId = id;
            this.Seats = seats;
            this.TableStatus = status;
        }

        public int getSeats()
        {
            return Seats;
        }

        public string getTableStatus()
        {
            return TableStatus;
        }

        public int getTableId()
        {
            return TableId;
        }
    }

    public class Employee //made by Machelle
    {
        int EmployeeId;
        string Firstname;
        string Lastname;
        string Password;
        string JobRole;
        string Username;

        public Employee()
        {
            //an empty constructor is nessecary to use an empty object (NULL)
        }

        public Employee(int id, string firstname, string lastname, string password, string jobRole, string username)
        {
            EmployeeId = id;
            Firstname = firstname;
            Lastname = lastname;
            Password = password;
            JobRole = jobRole;
            Username = username;
        }

        public int GetEmployeeId()
        {
            return EmployeeId;
        }

        public string GetFirstname()
        {
            return Firstname;
        }

        public string GetLastname()
        {
            return Lastname;
        }

        public string GetPassword()
        {
            return Password;
        }

        public string GetJobRole()
        {
            return JobRole;
        }

        public string GetUsername()
        {
            return Username;
        }
    }



    public class Order // Made by elizabeth
    {
        public List<string> items;

        public int orderId { get; set; }
        public int tableId { get; set; }
        public string comments { get; set; }
        public DateTime orderTime;
        public bool paidStatus;

        public Order()
        {
            //constructor
            items = new List<string>();
            tableId = 0;
            comments = "";
            orderTime = DateTime.Now;
            paidStatus = false;
        }

        public bool PlaceOrder()
        {
            return false;
        }

        public bool ModifyOrder()
        {
            return false;
        }

        public bool RemoveOrder()
        {
            return false;
        }

        public Order GetOrder()
        {
            //ChapeauDAL DB = new ChapeauDAL();

            //= DB.OrderDAO();
            return this;
        }
    }

}
