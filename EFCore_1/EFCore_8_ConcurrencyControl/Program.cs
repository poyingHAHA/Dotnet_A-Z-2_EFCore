using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;

namespace EFCore_8_ConcurrencyControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Name: ");
            string name = Console.ReadLine();

            using(MyDbContext ctx = new MyDbContext())
            using(var tx = ctx.Database.BeginTransaction())
            {
                Console.WriteLine(DateTime.Now+" - Ready for update");
                var h = ctx.Houses.FromSqlInterpolated(
                    $"select * from T_Houses where Id=2 for update"
                ).Single(); // 交易處理要用原生SQL查詢
                Console.WriteLine(DateTime.Now + " - 完成 select for update");


                //var h = ctx.Houses.Single(h => h.Id==1);
                if (!string.IsNullOrEmpty(h.Owner))
                {
                    if (h.Owner == name)
                    {
                        Console.WriteLine("你已經搶到了");
                    }
                    else
                    {
                        Console.WriteLine("房子已經被"+h.Owner+"占了");
                    }
                    Console.ReadLine();
                    return;
                }
                h.Owner = name;

                Thread.Sleep(10000); // 模擬併發
                Console.WriteLine("恭喜搶到資源");
                ctx.SaveChanges();
                Console.WriteLine("保存完成");
                tx.Commit();
                Console.ReadLine();
            }
        }
    }
}
