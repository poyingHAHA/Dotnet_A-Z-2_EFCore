using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;

namespace EFCore_10_ConcurrencyControlFromEFCore_RowVersion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Name: ");
            string name = Console.ReadLine();

            using (MyDbContext ctx = new MyDbContext())
            {
                var h = ctx.Houses.Single(h => h.Id == 3);

                if (!string.IsNullOrEmpty(h.Owner))
                {
                    if (h.Owner == name)
                    {
                        Console.WriteLine("你已經搶到了");
                    }
                    else
                    {
                        Console.WriteLine("房子已經被" + h.Owner + "占了");
                    }
                    Console.ReadLine();
                    return;
                }
                h.Owner = name;

                Thread.Sleep(10000);

                try
                {
                    ctx.SaveChanges();
                    Console.WriteLine("恭喜搶到資源");
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    Console.WriteLine("並行衝突");
                }
                Console.ReadLine();
            }
        }
    }
}
