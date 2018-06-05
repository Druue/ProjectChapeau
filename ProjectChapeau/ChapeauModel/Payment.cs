using System;
using System.Collections.Generic;

namespace Chapeau_Model
{
    public class Payment //Sophie
    {
        public int EmployeeId { get; set; }
        public double Vat { get; set; }
        public double Tip { get; set; }
        public double TotalPayment { get; set; }
        public string Comments { get; set; }
        public DateTime TimePayed { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public List<OrderItems> OrderItems { get; set; }

        public Payment(int employeeId , int vat, double tip, double totalPayment, string comments, PaymentMethod paymentMethod, OrderItems orderItems)
        {
            EmployeeId = employeeId;
            Vat = vat;
            Tip = tip;
            TotalPayment = totalPayment;
            Comments = comments;
            TimePayed = DateTime.Now;
            PaymentMethod = paymentMethod;
            OrderItems = OrderItems;
        }

        public PaymentMethod GetPaymentMethod()
        {
            //Check which button was checked on the form

            PaymentMethod pm = new PaymentMethod();
            return pm = 0;

        }
    }
}
