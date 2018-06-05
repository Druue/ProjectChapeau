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
    public partial class StockOverview : BaseForm
    {
        public StockOverview()
        {
            InitializeComponent();
            
        }
        public override string Text { get => base.Text; set => base.Text = "Stock"; }

        private void StockOverview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chapeau_1718_DB01DataSet2.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.chapeau_1718_DB01DataSet2.Menu);

        }

        private void stockDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerForm form = new managerForm();
            form.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string itemName = stockDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            int stock = (int)stockDataGridView.SelectedRows[0].Cells[1].Value;

            ChapeauLogic.EmployeeRepository stockOverview = new ChapeauLogic.EmployeeRepository();
            stockOverview.addStock(itemName, stock);
        }
    }
}
