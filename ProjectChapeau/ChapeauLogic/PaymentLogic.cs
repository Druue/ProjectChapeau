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
        public void InsertPayment(int employeeId, int orderId, int tableId, double tip, PaymentMethod paymentMethod, string comments)
        {
            Payment payment = new Payment
            {
                EmployeeId = employeeId, //gotten from machelle's part
                OrderId = orderId, //elizabeth's part?
                TableId = tableId, //machelle
                Tip = tip, //tip = user input from form
                Vat = 0,
                InitialPrice = 0,
                PaymentMethod = paymentMethod, //user input from form
                Comments = comments //user input from form
            };

            ChapeauDAL dal = new ChapeauDAL();
            List<OrderItems> orderItems = GetOrderItems(payment.OrderId, payment.TableId);

            foreach (OrderItems item in orderItems)
            {
                payment.Vat += item.Vat * item.ItemPrice;
                payment.InitialPrice += item.ItemPrice;
            }

            payment.TotalPrice = payment.Vat + payment.InitialPrice;

            dal.PaymentDAO(payment);
        }

        public List<OrderItems> GetOrderItems(int orderId, int tableId)
        {
            ChapeauDAL dal = new ChapeauDAL();
            List<OrderItems> orderItems = dal.OrderItemsDAO(orderId, tableId);

            return orderItems;
        }        
    }
}
