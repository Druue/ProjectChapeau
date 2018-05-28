using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using ChapeauLogic;
using ChapeauModel;

namespace ChapeauUI
{
    public class ManagerUI
    {
        public static List<Employee> showEmployees()
        {
            EmpolyeeOverview dbConn = new EmpolyeeOverview();
            List<Employee> employeeList = dbConn.GetEmployees();
                        
            Employee_listview.Items.Clear();

            foreach (var e in employeeList)
            {
                Employee_listview.SubItems.Add(e.firstName().ToString());

                Employee_listview.SubItems.Add(e.lastName().ToString());
               
                Employee_listview.Items.Add(employeeList);
            }

            return employeeList;
        }
    }
}
