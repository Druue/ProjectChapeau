using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapeau_Model;
using Chapeau_DAL;
using System.Data.SqlClient;

namespace Chapeau_Logic
{
    public class EmployeeRepository
    {
        public void Create(string firstname, string lastname, string jobrole, string password, string username)
        {
            ManagerDAO managerDAL = new ManagerDAO();
            managerDAL.createEmployee(firstname, lastname, jobrole, password, username);
        }

        public void Edit(string firstname, string lastname, string jobrole, string password, string username)
        {
            ManagerDAO managerDAL = new ManagerDAO();
            managerDAL.editEmployee(firstname, lastname, jobrole, password, username);
        }
        public void Delete(string firstname)
        {
            ManagerDAO managerDAL = new ManagerDAO();
            managerDAL.deleteEmployee(firstname);
        }

        public void AddStock(string itemname, int stock)
        {
            ManagerDAO managerDAL = new ManagerDAO();
            managerDAL.addStock(itemname, stock);
        }
    }
}