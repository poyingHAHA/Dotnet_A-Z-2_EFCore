using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_5_selfReferenceStruct
{
    internal class MyDbContext : DbContext
    {
        public DbSet<OrgUnit> Orgnits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                "Server=localhost; Database=demo4_selfRef; User Id=sa; Password=PaSSword12!; Trusted_Connection=False; MultipleActiveResultSets=true");



            // optionsBuilder.UseLoggerFactory(loggerFactory);
            //optionsBuilder.LogTo(msg =>
            //{
            //    if (!msg.Contains("CommandExecuting")) return;
            //    Console.WriteLine(msg);
            //});
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // 從當前assembly加載所有的IEntityTypeConfiguration
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
