using System;
using System.Collections.Generic;

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
            TableId = id;
            Seats = seats;
            TableStatus = status;
        }

        public int GetSeats()
        {
            return Seats;
        }

        public string GetTableStatus()
        {
            return TableStatus;
        }

        public int GetTableId()
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

        public int OrderId { get; set; }
        public int TableId { get; set; }
        public string Comments { get; set; }
        public DateTime orderTime;

        public Order()
        {
            //constructor
            items = new List<string>();
            TableId = 0;
            Comments = "";
            orderTime = DateTime.Now;
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
