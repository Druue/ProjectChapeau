using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapeau_Logic;

namespace ChapeauKitBarUI
{
    public class KitchenBarUI
    {
        public void GetOrders()
        {
            ChapeauLogic logic = new ChapeauLogic();
            logic.showOrders();
        }
    }
}
