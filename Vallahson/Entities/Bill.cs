using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Vallahson.Entities
{
    public class Bill
    {
        public int BillId { get; set; }

        public int Amount { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
