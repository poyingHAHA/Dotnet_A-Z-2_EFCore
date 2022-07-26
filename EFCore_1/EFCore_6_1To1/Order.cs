using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_6_1To1
{
    internal class Order
    {
        public long Id { get; set; }
        public string CompanyName { get; set; }
        public Delivery Delivery { get; set; }
    }
}
