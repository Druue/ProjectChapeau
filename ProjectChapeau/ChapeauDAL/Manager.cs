using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ChapeauModel;

namespace ChapeauDAL
{
    public class ManagerDAO
    {
        public List<Manager> Readall()
        {
            List<Manager> managerlist = new List<Manager>();

            try
            {
                SqlConnection sqlconn = new SqlConnection(@"Data Source=tcp:194.171.20.101;Initial Catalog=Chapeau_1718_DB01;User ID=Chapeau_1718_grp01;Password=PTR6gURrRx");
                sqlconn.Open();

                return sqlconn;

            }
            catch (SqlException e)
            {
                SqlConnection sqlconn = null;
                Console.WriteLine(e.ToString());
                return sqlconn;
            }
        }

        private void closeConnDB(SqlConnection sqlconn) 
        {
            sqlconn.Close();
        }


    }

}
