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
    public partial class OrderOverview : BaseForm
    {
        public OrderOverview()
        {
            InitializeComponent();
        }

        private void OrderOverview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chapeau_1718_DB01DataSet3.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.chapeau_1718_DB01DataSet3.Orders);


        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerForm form = new managerForm();
            form.ShowDialog();
        }
    }
}
