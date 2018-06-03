using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapeau_Model;
using Chapeau_DAL;

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

        public ChapeauModel.Employee LoginLogic()
        {
            ChapeauModel.Employee login = new ChapeauModel.Employee();


            return login;
        }


    }
}
