using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapeau_Model
{
    public class OrderItems
    {
        public string ItemName;
        public double ItemPrice;
        public double Vat;

        public OrderItems(string itemName, double itemPrice, double vat)
        {
            ItemName = itemName;
            ItemPrice = itemPrice;
            Vat = vat;
        }
    }
}
