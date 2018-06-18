using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapeau_Model;
using Chapeau_DAL;

namespace Chapeau_Logic
{
    public class PaymentLogic
    {
        public void InsertPayment(int employeeId, int orderId, double tip, PaymentMethod paymentMethod, string comments)
        {
            Payment payment = new Payment
            {
                EmployeeId = employeeId, //gotten from machelle's part
                OrderId = orderId, //elizabeth's part?
                Tip = tip, //tip = user input from form
                PaymentMethod = paymentMethod, //user input from form
                Comments = comments, //user input from form
                TimePayed = DateTime.Now
            };

            ChapeauDAL dal = new ChapeauDAL();
            List<OrderItems> orderItems = GetOrderItems(payment.OrderId);      

            dal.PaymentDAO(payment);
        }

        public Payment GetTotalPayments(int orderId)
        {
            Payment payment = new Payment();
            List<double> paymentDetails = new List<double>();

            List<OrderItems> orderItems = GetOrderItems(orderId);

            foreach (OrderItems item in orderItems)
            {
                payment.Vat += item.Vat * item.ItemPrice;
                payment.InitialPrice += item.ItemPrice;
            }

            payment.TotalPrice = payment.Vat + payment.InitialPrice;

            return payment;
        }

        public List<OrderItems> GetOrderItems(int orderId)
        {
            ChapeauDAL dal = new ChapeauDAL();
            List<OrderItems> orderItems = dal.OrderItemsDAO(orderId);

            return orderItems;
        }
    }
}
