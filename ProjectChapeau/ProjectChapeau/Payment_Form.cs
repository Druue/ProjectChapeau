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

        int orderId;
        int tableId;
        int employeeId;

        public Payment_Form()
        {
            InitializeComponent();
        }

        private void Payment_Form_Load(object sender, EventArgs e)
        {
            orderId = 1; //Elizabeth
            tableId = 1; //Henry
            employeeId = 1; //Machelle

            payMethod1.Appearance = Appearance.Button;
            payMethod2.Appearance = Appearance.Button;
            payMethod3.Appearance = Appearance.Button;

            orderItemsPaymentlv.Columns.Add("Menu Items");
            orderItemsPaymentlv.Columns.Add("Quantity");
            orderItemsPaymentlv.Columns.Add("Price");

            PaymentLogic pl = new PaymentLogic();
            List<OrderItems> orderItems = pl.GetOrderItems(orderId, tableId);

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

                /*Hide();
                RestaurantOverview_Form restaurantform = new RestaurantOverview_Form(employee);
                restaurantform.Show();*/
            }                        
        }

        private void FinishedPaymentBttn_Click(object sender, EventArgs e)
        {
            //string tipInput = CommentsTxt.Text;
            //int tip = Int32.Parse(tipInput);
            PaymentMethod paymentMethod = (PaymentMethod)1;
            double tip = 0.2;


            PaymentLogic pl = new PaymentLogic();
            pl.InsertPayment(employeeId, orderId, tableId, tip, paymentMethod, CommentsTxt.Text);
        }
    }
}
