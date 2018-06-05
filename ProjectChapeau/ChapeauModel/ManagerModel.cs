using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapeau_Model
{
    public class Employee
    {
        public int id;
        public int Id { get { return id; } set { id = value; } }
        public string firstName { get; set; }
        public string lastName { get; set; }


        public Employee()
        {

        }
    }


}