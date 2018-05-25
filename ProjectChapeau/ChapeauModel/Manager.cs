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
        public string FirstName { get; set; }
        public string LastName { get; set; }

               
        public Employee ()
        {

        }
    }
    public class EmpoleeList
    {
        List<Employee> sl = new List<Employee>();

        public void addList(Employee s)
        {
            sl.Add(s);
        }

        public List<Employee> getList()
        {
            return sl;
        }
    }
}

