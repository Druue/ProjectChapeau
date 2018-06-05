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

            Payment payment = new Payment();
            payment.EmployeeId = 1; //gotten from machelle's part
            payment.TableId = 1; //Gotten from table overview?
            payment.Tip = 0; //tip = user input from form
            payment.Vat = 0;
            payment.InitialPrice = 0;
            payment.PaymentMethod = 0; //PaymentMethod = user input from form
            payment.Comments = "";

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
    }
}
