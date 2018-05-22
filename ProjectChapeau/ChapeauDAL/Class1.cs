using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Chapeau_Model;

namespace ChapeauDAL
{
        public class ChapeauDAL
        {
            private SqlConnection openConnDB() //Made by Machelle
            {
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

            private void closeConnDB(SqlConnection sqlconn) //Made by Machelle
            {
                sqlconn.Close();
            }

            public List<ChapeauModel.TableTop> TableTopDAO()
            {
                SqlConnection conn = openConnDB();
                List<ChapeauModel.TableTop> table_list = new List<ChapeauModel.TableTop>();


                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT TableId, Seats, TableStatus FROM TableTop");
                String sql = sb.ToString();

                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ChapeauModel.TableTop table = new ChapeauModel.TableTop(Int32.Parse(reader["TableId"].ToString()), Int32.Parse(reader["Seats"].ToString()), reader["TableStatus"].ToString());
                    table_list.Add(table);
                }

                return table_list;
            }
        }
}
