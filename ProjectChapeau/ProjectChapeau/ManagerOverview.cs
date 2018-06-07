using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StyleGuide;


namespace ProjectChapeau
{
    public partial class managerForm : BaseForm
    {
        public managerForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            subtitleLabel.SendToBack();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.ShowDialog();

        }

        private void Employees_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeOverview form = new EmployeeOverview();
            form.ShowDialog();

        }

        private void textmanager_label_Click(object sender, EventArgs e)
        {

        }

        private void stock_button_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            StockOverview form = new StockOverview();
            form.ShowDialog();

        }

        private void orders_button_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            OrderOverview form = new OrderOverview();
            form.ShowDialog();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }
    }
    public class LoginForm : Form
    {

    }
}
