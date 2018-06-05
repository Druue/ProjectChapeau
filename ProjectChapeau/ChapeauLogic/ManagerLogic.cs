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
        public void create(string firstname, string lastname, string jobrole, string password, string username)
        {
            Chapeau_DAL.ManagerDAO managerDAL = new Chapeau_DAL.ManagerDAO();
            managerDAL.createEmployee(firstname, lastname, jobrole, password, username);
        }

        public void edit(string firstname, string lastname, string jobrole, string password, string username)
        {
            Chapeau_DAL.ManagerDAO managerDAL = new Chapeau_DAL.ManagerDAO();
            managerDAL.editEmployee(firstname, lastname, jobrole, password, username);
        }
        public void delete(string firstname)
        {
            Chapeau_DAL.ManagerDAO managerDAL = new Chapeau_DAL.ManagerDAO();
            managerDAL.deleteEmployee(firstname);
        }

        public void addStock(string itemname, int stock)
        {
            Chapeau_DAL.ManagerDAO managerDAL = new Chapeau_DAL.ManagerDAO();
            managerDAL.addStock(itemname, stock);
        }




    }
}