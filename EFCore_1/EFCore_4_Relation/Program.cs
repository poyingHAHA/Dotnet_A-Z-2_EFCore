using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EFCore_4_Relation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(MyDbContext ctx = new MyDbContext())
            {
                //Article a1 = new Article();
                //a1.Title = "台灣最帥";
                //a1.Message = "WAKU WAKU。。。";

                //Comment c1 = new Comment { Message="OMG..."};
                //Comment c2 = new Comment { Message="WTF..."};

                //a1.Comments.Add(c1);
                //a1.Comments.Add(c2);

                //ctx.Articles.Add(a1); // 只要將父對象加入，就不用再加c1、c2，當然要加也可以
                //ctx.SaveChanges();

                //Article a = ctx.Articles.Single(x => x.Id == 1);
                // 要使用Include做關聯才能得到Comment數據
                Article a = ctx.Articles.Include(a => a.Comments).Single(x => x.Id == 1);
                Console.WriteLine(a.Id);
                Console.WriteLine(a.Title);
                foreach(Comment comment in a.Comments)
                {
                    Console.WriteLine(comment.Message);
                }

                Comment cmt = ctx.Comments.Include(c=> c.TheArticle).Single(x => x.Id == 1);
                Console.WriteLine(cmt.Message);
                Console.WriteLine(cmt.TheArticle.Message);
            }
        }
    }
}
