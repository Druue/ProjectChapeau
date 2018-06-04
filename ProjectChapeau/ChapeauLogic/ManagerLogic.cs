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
        public void create(string firstname, string lastname, string jobrole, string password, string username)
        {
            ChapeauDAL.ManagerDAO managerDAL = new ChapeauDAL.ManagerDAO();
            managerDAL.createEmployee(firstname, lastname, jobrole, password, username);
        }

        public void edit(string firstname, string lastname, string jobrole, string password, string username)
        {
            ChapeauDAL.ManagerDAO managerDAL = new ChapeauDAL.ManagerDAO();
            managerDAL.editEmployee(firstname, lastname, jobrole, password, username);
        }
        public void delete(string firstname)
        {
            ChapeauDAL.ManagerDAO managerDAL = new ChapeauDAL.ManagerDAO();
            managerDAL.deleteEmployee(firstname);
        }

        public void addStock(string itemname)
        {
            ChapeauDAL.ManagerDAO managerDAL = new ChapeauDAL.ManagerDAO();
            managerDAL.addStock(itemname);
        }




    }
}
