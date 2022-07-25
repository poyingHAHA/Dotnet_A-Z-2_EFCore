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
            builder.Ignore(b => b.Age2);
            builder.Property(b=>b.Name2).HasColumnName("NameTwo").HasColumnType("varchar(10)");
            builder.Property(b=>b.AuthorName).HasColumnName("AuthorName").HasColumnType("nvarchar(10)");
            builder.HasIndex(b => b.Title).IsUnique();
            builder.HasIndex(b => new { b.Name2, b.AuthorName });
        }
    }
}
