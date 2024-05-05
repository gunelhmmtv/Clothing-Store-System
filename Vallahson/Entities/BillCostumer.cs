using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vallahson.Entities
{
    public class BillCustomer
    {

        public int Amount { get; set; }

        public string CustomerName { get; set; }

        public int BillId { get; set; }
        public int CustomerId { get; set; }
    }
}
