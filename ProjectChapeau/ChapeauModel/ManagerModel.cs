using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Employee
    {
        public int id;
        public int Id { get { return id; } set { id = value; } }
        public string firstName { get; set; }
        public string lastName { get; set; }

               
        public Employee ()
        {
            
        }
    }
    public class EmployeeList
    {
        List<Employee> sl = new List<Employee>();

        public void addList(Employee s)
        {
            sl.Add(s);
        }

        public List<Employee> GetList()
        {
            return sl;
        }
    }
}

