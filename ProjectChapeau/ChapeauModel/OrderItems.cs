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
        //public int ItemId;
        public double ItemPrice;
        public double Vat;

        public OrderItems(string itemName, /*int itemId,*/ double itemPrice, double vat)
        {
            ItemName = itemName;
            //ItemId = itemId;
            ItemPrice = itemPrice;
            Vat = vat;
        }
    }
}
