using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Chapeau_Logic;
using Chapeau_Model;

namespace ProjectChapeau
{
    public partial class Payment_Form : Form
    {
        public int panelWidth = 1400;
        public int panelHeight = 600;

        public Payment_Form()
        {
            InitializeComponent();
        }

        private void Payment_Form_Load(object sender, EventArgs e)
        {
            
            payMethod1.Appearance = Appearance.Button;
            payMethod2.Appearance = Appearance.Button;
            payMethod3.Appearance = Appearance.Button;

            orderItemsPaymentlv.Columns.Add("Menu Items");
            orderItemsPaymentlv.Columns.Add("Quantity");
            orderItemsPaymentlv.Columns.Add("Price");

            PaymentLogic pl = new PaymentLogic();
            List<OrderItems> orderItems = pl.GetOrderItems();

            try
            {
                if (orderItems.Count == 0)
                {
                    throw new Exception("Nothing has been ordered yet!");
                }

                for (int i = 0; i < orderItems.Count; i++)
                {
                    string[] item = { orderItems[i].ItemName, orderItems[i].Quantity.ToString(), orderItems[i].ItemPrice.ToString()};

                    ListViewItem lvi = new ListViewItem(item);
                    orderItemsPaymentlv.Items.Add(lvi);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                ex.Message,
                "Payment View Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation //For triangle Warning 
                                );
                Hide();
                RestaurantOverview_Form restaurantform = new RestaurantOverview_Form(employee);
                restaurantform.Show();
            }
            
        }
    }
}
