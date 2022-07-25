using System;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using (TestDbContext ctx = new TestDbContext())
            {
                // insert
                //Dog d = new Dog();
                //// id不用設定因為，EF會自動將Id設為KEY並自動增長
                //d.Name = "Xi";
                //ctx.Dogs.Add(d); // 把d物件加入Dogs這個邏輯的表上，還沒真正插入數據庫
                //await ctx.SaveChangesAsync(); // Update-Database 

                //Book b1 = new Book() { AuthorName="Edwin", Title="C#", Price=999, PubTime=new DateTime(2022,5,16)};
                //Book b2 = new Book() { AuthorName="John", Title="Java", Price=499, PubTime=new DateTime(2012,10, 1)};
                //Book b3 = new Book() { AuthorName="Jobs", Title="Apple", Price=9999, PubTime=new DateTime(2021,6,16)};
                //Book b4 = new Book() { AuthorName="Jeff", Title="SQL", Price=399, PubTime=new DateTime(2012,5,19)};
                //Book b5 = new Book() { AuthorName="Waku", Title="C", Price=999, PubTime=new DateTime(2020,6,16)};

                //Where
                //ctx.Books.Add(b1);
                //ctx.Books.Add(b2);
                //ctx.Books.Add(b3);
                //ctx.Books.Add(b4);
                //ctx.Books.Add(b5);
                //await ctx.SaveChangesAsync();

                //var books = ctx.Books.Where(b=>b.Price>80);
                //foreach (var b in books)
                //{
                //    Console.WriteLine(b.Title);
                //}

                //var book = ctx.Books.Single(b => b.Title == "Java");
                //Console.WriteLine(book.AuthorName);

                // GroupBy
                //var items = ctx.Books.GroupBy(b => b.PubTime.Year)
                //    .Select(g => new {Year=g.Key, BookCount=g.Count(), MaxPrice=g.Max(b=>b.Price)});

                //foreach (var item in items)
                //{
                //    Console.WriteLine($"{item.Year}, {item.BookCount}, {item.MaxPrice}");
                //}

                //修改
                //var b = ctx.Books.Single(b => b.Title == "Java");
                //b.AuthorName = "Edwin";

                //刪除
                //var dog = ctx.Dogs.Single(d => d.Id == 2);
                //ctx.Dogs.Remove(dog);

                //await ctx.SaveChangesAsync();

                //批量修改
                var books = ctx.Books.Where(b => b.Price > 10);
                foreach (var book in books)
                {
                    book.Price = book.Price+1;
                }
                await ctx.SaveChangesAsync();
            }

        }
    }
}
