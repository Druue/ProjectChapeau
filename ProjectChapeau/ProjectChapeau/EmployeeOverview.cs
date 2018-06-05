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
       
        public void Employee_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Employee_dataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this employee?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string firstName = Employee_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                    ChapeauLogic.EmployeeRepository employeeOverview = new ChapeauLogic.EmployeeRepository();
                    employeeOverview.delete(firstName);
                }
            }
            if (Employee_dataGridView.Columns[e.ColumnIndex].Name == "Edit")
            {
                
                string firstname = newFirstName.Text.ToString();
                string lastname = newLastName.Text.ToString();
                string jobRole = newJobRole.Text.ToString();
                string password = newPassword.Text.ToString();
                string username = newUsername.Text.ToString();

                ChapeauLogic.EmployeeRepository employeeOverview = new ChapeauLogic.EmployeeRepository();
                employeeOverview.edit(firstname, lastname, jobRole, password, username);
            }
        }

        private void EmployeeOverview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chapeau_1718_DB01DataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.chapeau_1718_DB01DataSet.Employee);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerForm form = new managerForm();
            form.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string firstname = newFirstName.Text.ToString();
            string lastname = newLastName.Text.ToString();
            string jobRole = newJobRole.Text.ToString();
            string password = newPassword.Text.ToString();
            string username = newUsername.Text.ToString();

            ChapeauLogic.EmployeeRepository employeeOverview = new ChapeauLogic.EmployeeRepository();            
            employeeOverview.create(firstname, lastname, jobRole, password, username);            
        }

        private void Employee_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (Employee_dataGridView.SelectedRows.Count < 2) // make sure user select not more 1 row 
            {
                string firstName = Employee_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                string lastName = Employee_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                string jobRole = Employee_dataGridView.SelectedRows[0].Cells[4].Value.ToString() ;
                string password = Employee_dataGridView.SelectedRows[0].Cells[5].Value.ToString() ;
                string userName = Employee_dataGridView.SelectedRows[0].Cells[6].Value.ToString();

                newFirstName.Text = firstName;
                newLastName.Text = lastName;
                newJobRole.Text = jobRole;
                newPassword.Text = password;
                newUsername.Text = userName;                
            }
            
        }
    }
}
