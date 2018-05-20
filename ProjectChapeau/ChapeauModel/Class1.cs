using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Class1
    {
    }

    public class TableTop
    {
       
        int TableId;
        int Seats;
        string TableStatus;

        public TableTop(int id, int seats, string status)
        {
            this.TableId = id;
            this.Seats = seats;
            this.TableStatus = status;
        }
    }
}
