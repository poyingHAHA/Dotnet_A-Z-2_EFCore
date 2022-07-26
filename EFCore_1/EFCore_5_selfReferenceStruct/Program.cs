using System;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_5_selfReferenceStruct
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // 可以直接指定Parent，或是用Children.Add的方式加入子節點
            OrgUnit ouRoot = new OrgUnit { Name="董事長"};
            OrgUnit ouAsia = new OrgUnit { Name = "亞州分部" };
            OrgUnit ouUSA = new OrgUnit { Name = "美國分部" };
            OrgUnit ouJP = new OrgUnit { Name = "日本分部" };
            OrgUnit ouTW = new OrgUnit { Name = "台灣分部" };
            OrgUnit ouCN = new OrgUnit { Name = "加拿大分部" };

            /* 這個方法Root在內存中的children是空的，所以表不會自動加
            ouAsia.Parent = ouRoot;
            ouUSA.Parent = ouRoot;
            ouTW.Parent = ouAsia;
            ouJP.Parent = ouAsia; */

            ouRoot.Children.Add(ouAsia);
            ouRoot.Children.Add(ouUSA);
            ouAsia.Children.Add(ouJP);
            ouAsia.Children.Add(ouTW);
            ouUSA.Children.Add(ouCN);

            using(MyDbContext ctx = new MyDbContext())
            {
                //ctx.Orgnits.Add(ouRoot);
                //await ctx.SaveChangesAsync();

                OrgUnit Root = ctx.Orgnits.Single(o => o.Parent == null); // 尋找根節點
                Console.WriteLine(Root.Name);
                PrintChildren(1, ctx, Root);
            }

            static void PrintChildren(int identLevel, MyDbContext ctx, OrgUnit parent)
            {
                var children = ctx.Orgnits.Where(o => o.Parent==parent);
                if(children == null)
                {
                    return;
                }
                foreach(var child in children)
                {
                    Console.WriteLine(new String('\t', identLevel)+child.Name);
                    PrintChildren(identLevel+1, ctx, child);
                }
            }
        }
    }
}
