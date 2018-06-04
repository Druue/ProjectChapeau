using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapeau_Model
{
    public class Payment
    {
        int id;        
        bool isPayed;
        double tip;
        double totalPayment;
        PaymentMethod paymentMethod;
    }
}
