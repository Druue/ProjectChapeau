using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectChapeau
{
    public class ChapeauDB
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

        public List<ChapeauModel.Tables> DB_getTables()
        {
            SqlConnection connection = openConnDB();
            List<ChapeauModel.Tables> studenten_lijst = new List<CheapeauModel.Tables>();

            //connection.Open();

            StringBuilder sb = new StringBuilder();
            // write your query here to ensure a list of students is shown
            sb.Append("SELECT Id, First_name, Last_name FROM Students");

            /* EXAMPLE QUERY */
            //sb.Append("SELECT TOP 20 pc.Name as CategoryName, p.name as ProductName ");
            //sb.Append("FROM [SalesLT].[ProductCategory] pc ");
            //sb.Append("JOIN [SalesLT].[Product] p ");
            //sb.Append("ON pc.productcategoryid = p.productcategoryid;");
            /* */

            String sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                SomerenModel.Student student = new SomerenModel.Student(Int32.Parse(reader["Id"].ToString()), reader["First_name"].ToString(), reader["Last_name"].ToString());
                studenten_lijst.Add(student);
            }

            return studenten_lijst;
        }
    }
    class ChapeauDAL
    {
    }
}
