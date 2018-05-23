using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauDAL;

namespace ChapeauLogic
{
    public class ManagerOverview
    {
        private ManagerDAO managerDAO = new ManagerDAO();

        public List<Manager> GetTafels()
        {
            List<Manager> TafelOverzicht = managerDAO.ReadAll();
            return managerOverview;
        }


    }
}
