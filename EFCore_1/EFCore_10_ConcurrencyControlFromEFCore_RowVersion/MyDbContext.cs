using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_10_ConcurrencyControlFromEFCore_RowVersion
{
    internal class MyDbContext : DbContext
    {
        public DbSet<House> Houses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var connStr = "server=localhost;user=root;database=concurrencyDemo2";
            var serverVersion = new MySqlServerVersion(new Version(8, 0));
            optionsBuilder.UseMySql(connStr, serverVersion);

            optionsBuilder.LogTo(msg =>
            {
                if (!msg.Contains("CommandExecuting")) return;
                Console.WriteLine(msg);
            });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
