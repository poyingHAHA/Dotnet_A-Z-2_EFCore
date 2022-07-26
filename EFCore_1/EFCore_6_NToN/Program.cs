using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_6_NToN
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            using(MyDbContext ctx = new MyDbContext())
            {
                /*
                Student s1 = new Student { Name="Edwin"};
                Student s2 = new Student { Name="John"};
                Student s3 = new Student { Name="Jobs"};

                Teacher t1 = new Teacher { Name = "teacher1" };
                Teacher t2 = new Teacher { Name = "teacher2" };
                Teacher t3 = new Teacher { Name = "teacher3" };
                Teacher t4 = new Teacher { Name = "teacher4" };

                s1.Teachers.Add(t1);
                s1.Teachers.Add(t2);

                s2.Teachers.Add(t3);
                s2.Teachers.Add(t4);

                s3.Teachers.Add(t2);
                s3.Teachers.Add(t3);
                s3.Teachers.Add(t4);

                ctx.Teachers.Add(t1);
                ctx.Teachers.Add(t2);
                ctx.Teachers.Add(t3);

                ctx.Students.Add(s1);
                ctx.Students.Add(s2);
                ctx.Students.Add(s3);
                await ctx.SaveChangesAsync();*/

                // 遍歷所有老師並列出所有學生。
                var teachers = ctx.Teachers.Include(t => t.Students);
                foreach(var t in teachers)
                {
                    Console.WriteLine(t.Name);
                    foreach(var student in t.Students)
                    {
                        Console.WriteLine("\t"+student.Name);
                    }
                }
            }
        }
    }
}
