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
        public int Quantity;
        public float ItemPrice;
        public float Vat;

        public OrderItems(string itemName, int quantity, float itemPrice, float vat)
        {
            ItemName = itemName;
            Quantity = quantity;
            ItemPrice = itemPrice;
            Vat = vat;
        }
    }
}
