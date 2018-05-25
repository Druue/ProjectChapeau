using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel;

namespace ChapeauUI
{
    public class Manager
    {
        public static Control showEmployees()
        {
            EmpolyeeOverview dbConn = new EmpolyeeOverview();
            List<Employee> emplyeeList = dbConn.GetEmployees();

            //Creating a list containter
            ListView emplyee = new ListView();
            emplyee.Height = ;//?
            emplyee.Width = ;//?
            emplyee.View = View.Details;
            emplyee.Scrollable = true;
            emplyee.GridLines = true;

            
            ColumnHeader rFirstName = new ColumnHeader();
            rFirstName.Text = "First Name";
            rFirstName.Name = "col2";
            rFirstName.Width = 100;
            emplyee.Columns.Add(rFirstName);

            ColumnHeader rLastName = new ColumnHeader();
            rLastName.Text = "Last Name";
            rLastName.Name = "col3";
            rLastName.Width = 100;
            emplyee.Columns.Add(rLastName);

            foreach (var e in emplyeeList)
            {
                ListViewItem employee = new ListViewItem(e.getId().ToString());

                employee.SubItems.Add(e.getFirstName().ToString());

                employee.SubItems.Add(e.getLastName().ToString());
                if (h.getId() % 2 != 0)
                {
                    emplyee.BackColor = Color.Khaki;
                }

                employee.Items.Add(emplyeeList);
            }

            return emplyeeList;
        }
    }
}
