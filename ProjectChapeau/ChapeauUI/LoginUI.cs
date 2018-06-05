using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapeau_Model;
using Chapeau_Logic;
//using ProjectChapeau;

namespace Chapeau_UI
{
    public class LoginUI
    {

        public ChapeauModel.Employee loginUI(string username, string password)
        {

            LoginLogic logic = new LoginLogic();

                ChapeauModel.Employee employee = logic.LoginCheck(username, password);


            return employee;
      
        }
    }

}
