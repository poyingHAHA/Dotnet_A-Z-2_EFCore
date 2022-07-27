using EFCore_4_Relation.OneWayDemoClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
            int id = 1;
            
            using(MyDbContext ctx = new MyDbContext())
            {
                //FormattableString fstr = @$"insert into T_Articles(Title, Message)
                //     select Title, Message from T_Articles where id>{id}";
                // 加@可以寫多行的字符串
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

                //DbConnection conn = ctx.Database.GetDbConnection(); // 獲得底層Connection對象
                //if(conn.State != System.Data.ConnectionState.Open)
                //{
                //    await conn.OpenAsync();
                //}

                //using(var cmd = conn.CreateCommand())
                //{
                //    cmd.CommandText = "select Title, Count(*) from T_Articles group by Title";
                //    using(var reader = await cmd.ExecuteReaderAsync())
                //    {
                //        while (await reader.ReadAsync())
                //        {
                //            string title = reader.GetString(0);
                //            int count = reader.GetInt32(1);
                //            Console.WriteLine($"{title}:{count}");
                //        }
                //    }
                //}

                //var items = ctx.Articles.Take(3).ToArray();
                //var a1 = items[0];
                //var a2 = items[1];
                //var a3 = items[2];

                //var a4 = new Article { Title = "aaa", Message = "xxxxx" };
                //var a5 = new Article { Title = "bbb", Message = "yyyyyy" };

                //a1.Title = "柏潁好可愛";
                //ctx.Remove(a2);
                //ctx.Articles.Add(a4);

                //EntityEntry e1 = ctx.Entry(a1);
                //EntityEntry e2 = ctx.Entry(a2);
                //EntityEntry e3 = ctx.Entry(a3);
                //EntityEntry e4 = ctx.Entry(a4);
                //EntityEntry e5 = ctx.Entry(a5);

                //Console.WriteLine(e1.State); // modified
                //Console.WriteLine(e1.DebugView.LongView); // 輸出快照與修改後訊息
                //Console.WriteLine(e2.State); // deleted
                //Console.WriteLine(e3.State); // unchanged
                //Console.WriteLine(e4.State); // addes
                //Console.WriteLine(e5.State); // detached

                //var items = ctx.Articles.AsNoTracking().Take(3).ToArray();
                //var a1 = items[0];
                //Console.WriteLine(ctx.Entry(a1).State); // detached

                // 不用select就直接修改數據庫，修改快照訊息
                //Article a = new Article { Id = 3, Title = "HaHaHaHa" };
                //ctx.Entry(a).Property("Title").IsModified = true;
                //ctx.SaveChanges();

                // 批量操作
                //ctx.RemoveRange(ctx.Articles.Where(z => z.Id > 5));
                //ctx.SaveChanges();

            }
        }
    }
}
