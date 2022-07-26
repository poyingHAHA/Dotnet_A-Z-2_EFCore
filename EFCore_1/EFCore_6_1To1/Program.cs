using EFCore_5_selfReferenceStruct;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_6_1To1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            using(MyDbContext ctx = new MyDbContext())
            {
                Order o1 = new Order();
                o1.CompanyName = "Book";

                Delivery d1 = new Delivery();
                d1.CompanyName = "BlackCat";
                d1.Number = "123123";
                d1.Order = o1;


                ctx.Orders.Add(o1);
                ctx.Deliveries.Add(d1);

                ctx.SaveChanges();
            }
        }
    }
}
