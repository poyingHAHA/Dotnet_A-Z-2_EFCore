using EFCore_4_Relation.OneWayDemoClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
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
                //FormattableString fstr = @$"insert into T_Articles(Title, Message)
                //     select Title, Message from T_Articles where id>{id}";
                //// 加@可以寫多行的字符串
                //Console.WriteLine(fstr.ArgumentCount);
                //Console.WriteLine(String.Join(", ", fstr.GetArguments());
                //await ctx.Database.ExecuteSqlInterpolatedAsync(fstr);

                //    string titlePattern = "%台%";
                //    var querable = ctx.Articles.FromSqlInterpolated($@"select * from T_Articles 
                //                    where Title like {titlePattern} order by newid()");

                //    foreach(var a in querable)
                //    {
                //        Console.WriteLine(a.Id+", "+a.Title);
                //    }

                DbConnection conn = ctx.Database.GetDbConnection(); // 獲得底層Connection對象
                if(conn.State != System.Data.ConnectionState.Open)
                {
                    await conn.OpenAsync();
                }

                using(var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select Title, Count(*) from T_Articles group by Title";
                    using(var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            string title = reader.GetString(0);
                            int count = reader.GetInt32(1);
                            Console.WriteLine($"{title}:{count}");
                        }
                    }
                }
            }
        }
    }
}
