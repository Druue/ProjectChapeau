using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Payment //Sophie
    {
        public int Id { get; private set; }
        public int Vat { get; set; }
        public double Tip { get; set; }
        public double TotalPayment { get; set; }
        public bool IsPayed { get; set; }
        public string Comments { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        //public List<MenuItems> MenuItems { get; set; } (DAL STUFF - FIX LATER)

        public Payment(int id, int vat, double tip, double totalPayment, bool isPayed, string comments, PaymentMethod paymentMethod)
        {
            Id = id;
            Vat = vat;
            Tip = tip;
            TotalPayment = totalPayment;
            IsPayed = isPayed;
            Comments = comments;
            PaymentMethod = paymentMethod;
            //MenuItems = menuitems; (DAL STUFF - FIX LATER)
        }
    }
}
