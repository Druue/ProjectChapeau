using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapeau_DAL;
using Chapeau_Model;

namespace Chapeau_Logic
{
    public class ChapeauLogic
    {
        public List<ChapeauModel.Order> showOrders()
        {
            ChapeauDAL stuff = new ChapeauDAL();
            List<ChapeauModel.Order> orderList = stuff.OrderDAO();

            return orderList;
        }
    }
}
