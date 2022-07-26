using EFCore_4_Relation.OneWayDemoClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_4_Relation
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            int id = 2;
            
            using(MyDbContext ctx = new MyDbContext())
            {
                FormattableString fstr = @$"insert into T_Articles(Title, Message)
                     select Title, Message from T_Articles where id>{id}";
                // 加@可以寫多行的字符串
                Console.WriteLine(fstr.ArgumentCount);
                Console.WriteLine(String.Join(", ", fstr.GetArguments());
                await ctx.Database.ExecuteSqlInterpolatedAsync(fstr);
            }
        }
    }
}
