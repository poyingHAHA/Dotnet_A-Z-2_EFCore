using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_1
{
    internal class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            // EF Core有約定大於配置的特性，所以這個類是可以不用建的
            builder.ToTable("T_Books");
            builder.Property(b => b.Title).HasMaxLength(50).IsRequired();
        }
    }
}
