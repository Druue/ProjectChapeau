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
using Chapeau_Logic;

namespace ProjectChapeau
{
    public partial class StockOverview : BaseForm
    {
        public StockOverview()
        {
            InitializeComponent();
        }

        private void StockOverview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chapeau_1718_DB01DataSet.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.chapeau_1718_DB01DataSet.Menu);

        }

        private void baseButton11_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerOverview form = new ManagerOverview();
            form.ShowDialog();
        }

        private void baseButton12_Click_1(object sender, EventArgs e)
        {
            string itemName = stockDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            int stock = (int)stockDataGridView.SelectedRows[0].Cells[1].Value;

            EmployeeRepository stockOverview = new EmployeeRepository();
            stockOverview.AddStock(itemName, stock);
        }

        private void stockDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
