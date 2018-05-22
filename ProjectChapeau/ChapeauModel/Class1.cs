using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
        public class ChapeauModel
        {

            public class TableTop
            {

                int TableId;
                int Seats;
                string TableStatus;

                public TableTop()
                {

                }

                public TableTop(int id, int seats, string status)
                {
                    this.TableId = id;
                    this.Seats = seats;
                    this.TableStatus = status;
                }

                public int getSeats()
                {
                    return Seats;
                }

                public string getTableStatus()
                {
                    return TableStatus;
                }

                public int getTableId()
                {
                    return TableId;
                }
            }
        }
}

