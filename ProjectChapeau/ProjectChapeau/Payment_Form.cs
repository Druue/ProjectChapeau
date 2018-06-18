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
            orderId = 49; //Elizabeth + Henry
            employeeId = 1; //Machelle

            payMethod1.Appearance = Appearance.Button; //Payment Method Buttons
            payMethod1.BackgroundImageLayout = ImageLayout.Stretch;
            payMethod2.Appearance = Appearance.Button;
            payMethod2.BackgroundImageLayout = ImageLayout.Stretch;
            payMethod3.Appearance = Appearance.Button;
            payMethod3.BackgroundImageLayout = ImageLayout.Stretch;

            TipInputnum.Value = 0; //NumericUpDown -> TipInput
            TipInputnum.Minimum = 0;
            TipInputnum.DecimalPlaces = 2;

            orderItemsPaymentlv.View = View.Details;  //Items that have been ordered
            orderItemsPaymentlv.Columns.Add("Menu Items", 180, HorizontalAlignment.Left);
            orderItemsPaymentlv.Columns.Add("Quantity", 70, HorizontalAlignment.Left);
            orderItemsPaymentlv.Columns.Add("Price", 65, HorizontalAlignment.Left);

            orderDetailsPaymentlv.View = View.Details; //Final Payment Values
            orderDetailsPaymentlv.Columns.Add("Vat", 310/3, HorizontalAlignment.Center);
            orderDetailsPaymentlv.Columns.Add("Vat-Free Price", 310/3, HorizontalAlignment.Center);
            orderDetailsPaymentlv.Columns.Add("Final Price", 310/3, HorizontalAlignment.Center);

            PaymentLogic pl = new PaymentLogic();
            List<OrderItems> orderItems = pl.GetOrderItems(orderId);
            Payment finalValues = pl.GetTotalPayments(orderId);
            
            try
            {
                if (orderItems.Count == 0)
                {
                    throw new Exception("Either nothing has been ordered yet, or it hasn't been completed!");
                }

                for (int i = 0; i < orderItems.Count; i++)
                {
                    orderItemsPaymentlv.Items.Add(orderItems[i].ItemName);
                    orderItemsPaymentlv.Items[i].SubItems.Add(orderItems[i].Quantity.ToString());
                    orderItemsPaymentlv.Items[i].SubItems.Add(orderItems[i].ItemPrice.ToString("0.00"));

                    if (i < 1)
                    {
                        orderDetailsPaymentlv.Items.Add(finalValues.Vat.ToString("0.00"));
                        orderDetailsPaymentlv.Items[i].SubItems.Add(finalValues.InitialPrice.ToString("0.00"));
                        orderDetailsPaymentlv.Items[i].SubItems.Add(finalValues.TotalPrice.ToString("0.00"));
                    }                    
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
            double tip = double.Parse(TipInputnum.Value.ToString()); //user input
            
            PaymentLogic pl = new PaymentLogic();
            pl.InsertPayment(employeeId, orderId, tip, paymentMethod, CommentsTxt.Text);
        }

        private void CancelPaymentbttn_Click(object sender, EventArgs e)
        {
            //open previous form
        }

        private void TipInputnum_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
