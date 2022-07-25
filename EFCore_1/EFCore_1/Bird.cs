using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_1
{
    internal class Bird
    {
        public long Id { get; set; }
        public string Name { get; set; }

        //[Key]
        public string Number { get; set; }
    }
}
