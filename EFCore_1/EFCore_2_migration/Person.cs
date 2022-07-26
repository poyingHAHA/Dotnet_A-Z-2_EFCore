using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_2_migration
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public double Weight { get; set; }
        public DateTime Birthday { get; set; }
    }
}
