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
    public class Manager
    {
        public static List<Employee> showEmployees()
        {
            EmpolyeeOverview dbConn = new EmpolyeeOverview();
            List<Employee> emplyeeList = dbConn.GetEmployees();

            
            Employee_listview.Items.Clear();


            foreach (var e in emplyeeList)
            {


                Employee_listview.SubItems.Add(e.firstName().ToString());

                Employee_listview.SubItems.Add(e.lastName().ToString());
               
                Employee_listview.Items.Add(emplyeeList);
            }

            return emplyeeList;
        }
    }
}
