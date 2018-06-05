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
            Chapeau_DAL.Chapeau_DAL stuff = new Chapeau_DAL.Chapeau_DAL();
            List<ChapeauModel.Order> orderList = stuff.OrderDAO();

            return orderList;
        }
    }
}
