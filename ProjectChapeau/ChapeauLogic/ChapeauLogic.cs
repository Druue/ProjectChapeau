﻿using System;
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
        public void showOrders()
        {
            ChapeauDAL stuff = new ChapeauDAL();
            stuff.OrderDAO(); 
            //ChapeauModel.Order order = new ChapeauModel.Order();

            //return order;
        }

        public ChapeauModel.Employee LoginLogic()
        {
            ChapeauModel.Employee login = new ChapeauModel.Employee();


            return login;
        }


    }
}
