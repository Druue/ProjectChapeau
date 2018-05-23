using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Manager
    {
        public int id;
        public int Id { get { return id; } set { id = value; } }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return this.FirstName + " " + this.LastName; }
        }
        
        public Manager ()
        {

        }
    }
    public class ManagerOverview
    {
        List<Manager> sl = new List<Manager>();

        public void addList(Manager s)
        {
            sl.Add(s);
        }

        public List<Manager> getList()
        {
            return sl;
        }
    }
}

