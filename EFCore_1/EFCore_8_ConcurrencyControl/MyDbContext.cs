using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_8_ConcurrencyControl
{
    internal class MyDbContext : DbContext
    {
        public DbSet<House> Houses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var connStr = "server=localhost;user=root;database=concurrencyDemo";
            var serverVersion = new MySqlServerVersion(new Version(8, 0));
            optionsBuilder.UseMySql(connStr, serverVersion);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
