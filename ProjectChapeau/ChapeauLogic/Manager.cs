using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauDAL;

namespace ChapeauLogic
{
    public class EmpolyeeOverview
    {
        private ManagerDAO managerDAO = new ManagerDAO();

        public List<Employee> GetEmployees()
        {
            List<Employee> employeeList = managerDAO.ReadAll();
            return employeeList;
        }


    }
}
