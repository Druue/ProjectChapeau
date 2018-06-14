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
    public partial class ManagerOverview : BaseForm
    {
        public ManagerOverview()
        {
            InitializeComponent();
        }

        private void ManagerOverview_Load(object sender, EventArgs e)
        {

        }

        private void baseButton14_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.ShowDialog();
        }

        private void baseButton11_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeOverview form = new EmployeeOverview();
            form.ShowDialog();
        }

        private void baseButton12_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockOverview form = new StockOverview();
            form.ShowDialog();
        }

        private void baseButton13_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderOverview form = new OrderOverview();
            form.ShowDialog();
        }
    }
}
