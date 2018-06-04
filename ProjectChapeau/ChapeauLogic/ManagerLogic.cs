using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauDAL;
using System.Data.SqlClient;

namespace ChapeauLogic
{
    public class EmployeeRepository
    {
        private ManagerDAO managerDAO = new ManagerDAO();

        public void createEmployee(string firstname, string lastname, string jobrole, string password, string username)
        {
            var connection = this.managerDAO.openConnectionDB();
            var command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO Employee (Firstname,Lastname,JobRole,Password,Username) VALUES(" +firstname+","+lastname+","+jobrole+","+password+","+username+")";
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void editEmployee(string firstname, string lastname, string jobrole, string password, string username)
        {
            var connection = this.managerDAO.openConnectionDB();
            var command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "UPDATE Emloyee SET Firstname = " + firstname + ",Lastname = " + lastname + ",JobRole = " + jobrole + ",Password =  " + password + ",Username = " + username + ";"; // UPDATE COMMANT
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void deleteEmployee(string name)
        {
            var connection = this.managerDAO.openConnectionDB();
            var command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "DELETE FROM Employee WHERE Firstname = '"+name+"' ";
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void addStock(string name)
        {
            var connection = this.managerDAO.openConnectionDB();
            var command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "UPDATE Menu SET Stock = Stock + 1; WHERE itemName = " +name+"";
            command.ExecuteNonQuery();
            connection.Close();
        }


    }
}
