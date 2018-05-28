using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectChapeau
{
    public partial class EmployeeOverview : Form
    {
        public EmployeeOverview()
        {
            InitializeComponent();
        }

        public void Employee_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EmployeeOverview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chapeau_1718_DB01DataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.chapeau_1718_DB01DataSet.Employee);

        }

        public void backButtonEmployeeOverview_Clicked (object sender, EventArgs e)
        {

        }
    }
}
