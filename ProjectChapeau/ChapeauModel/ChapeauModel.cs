using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapeau_Model
{
    public class ChapeauModel
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
                this.EmployeeId = id;
                this.Firstname = firstname;
                this.Lastname = lastname;
                this.Password = password;
                this.JobRole = jobRole;
                this.Username = username;
            }

            public int getEmployeeId()
            {
                return EmployeeId;
            }

            public string getFirstname()
            {
                return Firstname;
            }

            public string getLastname()
            {
                return Lastname;
            }

            public string getPassword()
            {
                return Password;
            }

            public string getJobRole()
            {
                return JobRole;
            }

            public string getUsername()
            {
                return Username;
            }

        }
    }
}
