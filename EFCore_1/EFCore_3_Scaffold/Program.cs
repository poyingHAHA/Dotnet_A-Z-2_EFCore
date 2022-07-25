using System;
using System.Linq;

namespace EFCore_3_Scaffold
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(demo_migrationContext ctx = new demo_migrationContext())
            {
                Console.WriteLine(ctx.TPeople.Count());
            }
        }
    }
}
