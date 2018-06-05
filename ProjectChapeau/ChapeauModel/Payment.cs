using System;

namespace Chapeau_Model
{
    public class Payment //Sophie
    {
        public int EmployeeId { get; set; }
        public double Vat { get; set; }
        public double Tip { get; set; }
        public double TotalPayment { get; set; }
        //public bool IsPayed { get; set; } not sure if keeping
        public string Comments { get; set; }
        public DateTime TimePayed { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        //public List<MenuItems> MenuItems { get; set; } (FIX LATER)

        //public Payment() Not sure if empty constructor is needed
        //{

        //}

        public Payment(int employeeId , int vat, double tip, double totalPayment, bool isPayed, string comments, PaymentMethod paymentMethod)
        {
            EmployeeId = employeeId;
            Vat = vat;
            Tip = tip;
            TotalPayment = totalPayment;
            //IsPayed = isPayed;
            Comments = comments;
            TimePayed = DateTime.Now;
            PaymentMethod = paymentMethod;
            //MenuItems = menuitems; (FIX LATER)
        }
    }
}
