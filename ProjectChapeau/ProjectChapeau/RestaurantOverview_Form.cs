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
        public RestaurantOverview_Form()
        {
            InitializeComponent();

            TableTopLogic tablelogic = new TableTopLogic();
            List<TableTop> AllTables = tablelogic.tableTopListLogic();

            foreach (TableTop table in AllTables)
            {
                TableButton tablebutton = new TableButton(table);

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

        public class TableButton : Button
        {

            public TableButton(TableTop table)
            {
                this.Size = new Size(60, 60);
                this.Text = table.GetTableId().ToString();
                
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
        }
    }



}
