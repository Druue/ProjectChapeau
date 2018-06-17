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
        public PaymentLogic()
        {
            int itemid = 1;
            int orderid = 1;

            Payment payment = new Payment
            {
                EmployeeId = 1, //gotten from machelle's part
                TableId = 1, //Gotten from table overview?
                Tip = 0, //tip = user input from form
                Vat = 0,
                InitialPrice = 0,
                PaymentMethod = 0, //PaymentMethod = user input from form
                Comments = ""
            };

            ChapeauDAL dal = new ChapeauDAL();
            List<OrderItems> orderItems = dal.OrderItemsDAO(itemid, orderid);

            foreach (OrderItems item in orderItems)
            {
                payment.Vat += item.Vat * item.ItemPrice;
                payment.InitialPrice += item.ItemPrice;
            }

            payment.TotalPrice = payment.Vat + payment.InitialPrice;            
            
            dal.PaymentDAO(payment);
        }

        public List<OrderItems> GetOrderItems()
        {
            int itemid = 1;
            int orderid = 1;

            ChapeauDAL dal = new ChapeauDAL();
            List<OrderItems> orderItems = dal.OrderItemsDAO(itemid, orderid);

            return orderItems;
        }        
    }
}
