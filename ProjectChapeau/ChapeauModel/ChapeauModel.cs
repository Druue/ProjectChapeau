using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapeau_Model
{
    public class ChapeauModel
    {
       

        public class Employee //made by Machelle
        {
           public int EmployeeId;
           public  string Firstname;
           public string Lastname;   //set these to public
           public string Password;
           public JobRole Role;
           public  string Username;

            public Employee()
            {
                //an empty constructor is nessecary to use an empty object (NULL)
            }

            public Employee(int id, string firstname, string lastname, string password, JobRole role, string username)
            {
                EmployeeId = id;
                Firstname = firstname;
                Lastname = lastname;
                Password = password;
                Role = role;
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

            public JobRole GetJobRole()
            {
                return Role;
            }

            public string GetUsername()
            {
                return Username;
            }

        }

 

        public class Order // Made by elizabeth
        {
            public string item;
            public int orderId { get; set; }
            public int tableId { get; set; }
            public string comments { get; set; }
            public DateTime orderTime;
            //public bool paidStatus;

            public Order()
            {
                //constructor
                this.item = "";
                this.tableId = 0;
                this.comments = "";
                this.orderTime = DateTime.Now;
               // this.paidStatus = false;
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
}

