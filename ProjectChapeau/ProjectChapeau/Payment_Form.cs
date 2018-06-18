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
        int employeeId;

        public Payment_Form()
        {
            InitializeComponent();
        }

        private void Payment_Form_Load(object sender, EventArgs e)
        {
            orderId = 4; //Elizabeth + Henry
            employeeId = 1; //Machelle

            payMethod1.Appearance = Appearance.Button;
            payMethod2.Appearance = Appearance.Button;
            payMethod3.Appearance = Appearance.Button;

            orderItemsPaymentlv.View = View.Details;
            orderItemsPaymentlv.Columns.Add("Menu Items", 170, HorizontalAlignment.Left);
            orderItemsPaymentlv.Columns.Add("Quantity", 67, HorizontalAlignment.Left);
            orderItemsPaymentlv.Columns.Add("Price", 60, HorizontalAlignment.Left);

            orderDetailsPaymentlv.View = View.SmallIcon;

            PaymentLogic pl = new PaymentLogic();
            List<OrderItems> orderItems = pl.GetOrderItems(orderId);
            
            try
            {
                if (orderItems.Count == 0)
                {
                    throw new Exception("Nothing has been ordered yet!");
                }

                for (int i = 0; i < orderItems.Count; i++)
                {
                    orderItemsPaymentlv.Items.Add(orderItems[i].ItemName);
                    orderItemsPaymentlv.Items[i].SubItems.Add(orderItems[i].Quantity.ToString());
                    orderItemsPaymentlv.Items[i].SubItems.Add(orderItems[i].ItemPrice.ToString());
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
            PaymentMethod paymentMethod = (PaymentMethod)1; //user input
            double tip = 0.2; //user input


            PaymentLogic pl = new PaymentLogic();
            pl.InsertPayment(employeeId, orderId, tip, paymentMethod, CommentsTxt.Text);
        }
    }
}
