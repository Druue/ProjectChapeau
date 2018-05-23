using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows;
using Chapeau_Model;

namespace Chapeau_UI
{
    public class ChapeauUI
    {
        public static Control Manager()
        {
            //fetch students from DB
            Chap dbConn = new SomerenDB();
            List<ChapeauModel.TableTop> studentlist = dbConn.DB_getStudents();

            //Create list containter
            ListView student = new ListView();
            student.Height = 400;
            student.Width = 757;
            student.View = View.Details;
            student.Scrollable = true;
            student.GridLines = true;

            ColumnHeader rID = new ColumnHeader();
            rID.Text = "Student ID";
            rID.Name = "col1";
            rID.Width = 100;
            student.Columns.Add(rID);

            ColumnHeader rFirstName = new ColumnHeader();
            rFirstName.Text = "First Name";
            rFirstName.Name = "col2";
            rFirstName.Width = 100;
            student.Columns.Add(rFirstName);

            ColumnHeader rLastName = new ColumnHeader();
            rLastName.Text = "Last Name";
            rLastName.Name = "col3";
            rLastName.Width = 100;
            student.Columns.Add(rLastName);

            foreach (var h in studentlist)
            {
                ListViewItem students = new ListViewItem(h.getId().ToString());

                students.SubItems.Add(h.getFirstName().ToString());

                students.SubItems.Add(h.getLastName().ToString());
                if (h.getId() % 2 != 0)
                {
                    students.BackColor = Color.Khaki;
                }

                student.Items.Add(students);
            }

            return student;
        }

    }
}
