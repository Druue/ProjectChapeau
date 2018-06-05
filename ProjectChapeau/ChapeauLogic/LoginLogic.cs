using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapeau_DAL;
using Chapeau_Model;

namespace Chapeau_Logic
{
    public class LoginLogic
    {
        
        
        public ChapeauModel.Employee LoginCheck(string username, string password)
        {
            Chapeau_DAL.Chapeau_DAL dal = new Chapeau_DAL.Chapeau_DAL();

            ChapeauModel.Employee employee = dal.LoginDAO(username, password);

               return employee;


        }

        

    }
}
