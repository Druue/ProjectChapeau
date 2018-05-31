using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectChapeau
{
    public partial class EmployeeOverview : Form
    {
        public EmployeeOverview()
        {
            InitializeComponent();
        }
        int selectedRow;
        public void Employee_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (Employee_dataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this employee?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    //deleting the rown that was selected
                    selectedRow = Employee_dataGridView.CurrentCell.RowIndex;
                    Employee_dataGridView.Rows.RemoveAt(selectedRow);
                }
            }
        }

        private void EmployeeOverview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chapeau_1718_DB01DataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.chapeau_1718_DB01DataSet.Employee);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerForm form = new managerForm();
            form.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // pop up massase with what needs to be added then that will be added to de db

        }
    }
}
