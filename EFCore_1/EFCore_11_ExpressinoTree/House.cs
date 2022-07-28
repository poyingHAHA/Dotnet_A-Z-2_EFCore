using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_11_ExpressinoTree
{
    internal class House
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public double Price { get; set; }
        public byte[] RowVersion { get; set; }

        public override string ToString()
        {
            return $"Id={Id}, Name={Name}, Owner={Owner}, Price={Price}, RowVersion={RowVersion}";
        }
    }
}
