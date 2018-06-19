using System;
using System.Windows.Forms;
using Chapeau_Model;

namespace ProjectChapeau
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*TableTop table = new TableTop();
             ChapeauModel.Employee emp = new ChapeauModel.Employee();
             Application.Run(new OrderingForm(table, emp));*/
            Application.Run(new LoginForm());
        }
    }
}
