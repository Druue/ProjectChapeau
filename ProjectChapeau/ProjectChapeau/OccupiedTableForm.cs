using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chapeau_Model;
using Chapeau_Logic;

namespace ProjectChapeau
{
    public partial class OccupiedTableForm : Form
    {
        private int tableId;

        public OccupiedTableForm(int tableId)
        {
            InitializeComponent();
            this.tableId = tableId;
            FillTableList();
        }

        private void FillTableList()
        {
            tableReceiptListView.HideSelection = false;
            tableReceiptListView.Items.Clear();
            List<OrderingModel.Item> TableItemsList = new List<OrderingModel.Item>();
            TableItemsList = OrderingLogic.CallTableItemsDB(this.tableId);

            foreach (OrderingModel.Item TableItem in TableItemsList)
            {

                ListViewItem LvTableItem = new ListViewItem(TableItem.Name);
                LvTableItem.SubItems.Add("...................");
                LvTableItem.SubItems.Add(TableItem.itemPrice.ToString());
                tableReceiptListView.Items.Add(LvTableItem);
            }

        }

        private void tableReceiptListView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void startPaymentButton_Click(object sender, EventArgs e)
        {
            Payment_Form payment = new Payment_Form();
            payment.Show();
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusDisplayLabel.Text = statusComboBox.Text;
        }

    }
}
