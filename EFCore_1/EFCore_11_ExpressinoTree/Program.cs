
using ExpressionTreeToString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EFCore_11_ExpressinoTree
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Expression<Func<House, bool>> e1 = b => b.Price > 5;
            //Expression<Func<House, House, double>> e2 = (b1, b2) => b1.Price + b2.Price;
            Expression<Func<House, bool>> e3 = e => e.Owner == "Edwin";

            //Console.WriteLine(e2.ToString("Object notation", "C#"));
            Console.WriteLine(e3.ToString("Factory methods", "C#"));


            using (MyDbContext ctx = new MyDbContext())
            {
                var h = ctx.Houses.Single(e3);
                Console.WriteLine(h.Owner);
            }
        }

        static IEnumerable<House> QueryHouses(string propertyName, object value)
        {
            using(MyDbContext ctx = new MyDbContext())
            {
                Expression<Func<House, bool>> e1;
                var h = Parameter(
                        typeof(House),
                        "h"
                    )

                Type valueType = value.GetType();
                if(valueType.IsPrimitive)
                {
                    e1 = Lambda<Func<House, bool>>(
                            Equal(
                                MakeMemberAccess(
                                    typeof(House).GetProperty("Price")                                        
                                ),
                                Constant
                            )
                        )
                }
            }
        }
    }
}
