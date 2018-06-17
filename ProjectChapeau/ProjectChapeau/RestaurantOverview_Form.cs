using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chapeau_Logic;
using Chapeau_UI;
using Chapeau_Model;

namespace ProjectChapeau
{
    public partial class RestaurantOverview_Form : Form
    {
        public RestaurantOverview_Form(ChapeauModel.Employee employee) //Machelle
        {
            InitializeComponent();


            TableTopLogic tablelogic = new TableTopLogic();
            List<TableTop> AllTables = tablelogic.tableTopListLogic();

            lbl_loggedinEmployee.ForeColor = Color.Black;
            lbl_loggedinEmployee.Text = employee.Firstname + " " + employee.Lastname;
            lbl_loggedinEmployee.Font =new Font(lbl_loggedinEmployee.Font, FontStyle.Bold);
            pnl_topbar.Controls.Add(lbl_loggedinEmployee);

            foreach (TableTop table in AllTables)
            {
                TableButton tablebutton = new TableButton(table, this);

                if (table.GetTableId() % 2 == 0)
                {
                    this.flowlaypnl_table_overview_even.Controls.Add(tablebutton); //add the even buttons here (2,4,6,8,10)
                }
                else
                {
                    this.flowlaypnl_table_overview_uneven.Controls.Add(tablebutton); //add the uneven buttons here (1,3,5,7,9)
                }
            }
        }

        public class TableButton : Button //Machelle
        {

            public TableButton(TableTop table, RestaurantOverview_Form form)
            {
                this.Size = new Size(80, 80);
                this.Font = new Font("Arial", 12, FontStyle.Bold);
                this.Text = table.GetTableId().ToString();                
                this.Click += new EventHandler((s, ev) => TableButton_Click(s, ev, table, form));
                this.Margin = new Padding(4,14, 4, 4);

                if (table.GetTableStatus() == TableStatus.Available)
                {
                    this.BackColor = Color.Green;
                }
                else if (table.GetTableStatus() == TableStatus.Occupied)
                {
                    this.BackColor = Color.Red;
                }
                else if (table.GetTableStatus() == TableStatus.Reserved)
                {
                    this.BackColor = Color.LightYellow;
                }


            }

            public void TableButton_Click(object sender, EventArgs e, TableTop table, RestaurantOverview_Form form)
            {

              form.Hide();

                if (table.GetTableStatus() == TableStatus.Available)
                {
                    OrderingForm ordering = new OrderingForm(table);
                    ordering.Show();
                }
                else
                {
                    OccupiedTableForm occupied = new OccupiedTableForm(table.GetTableId());
                    occupied.Show();
                }
                
                



                MessageBox.Show("Yaaay the eventhandlers work! :D table number: " + table.GetTableId());
                //HENRY:
                //create your form in here, use the following: YourFormName yourform = new YourFormName(table); then set that to yourform.Show();
                //You can use the table.TableId that I passed in this eventhandler in your form to make changes to the right table!

            }
        }

        private void btn_logoff_Click(object sender, EventArgs e)
        {

            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }


    }



}
