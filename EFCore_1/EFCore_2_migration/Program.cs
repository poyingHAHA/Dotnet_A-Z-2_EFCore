using System;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_2_migration
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using(MyDbContext ctx = new MyDbContext())
            {
                //ctx.People.Add(new Person { Name = "Edwin", Height = 180 });
                //ctx.People.Add(new Person { Name = "John", Height = 170 });
                //ctx.People.Add(new Person { Name = "Jeff", Height = 160 });
                //var people = ctx.People.Where(p => p.Name == "Edwin");
                //await ctx.SaveChangesAsync();
                //foreach(var person in people)
                //{
                //    Console.WriteLine(person.Name);
                //}


            }
        }
    }
}
