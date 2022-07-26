using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_4_Relation
{
    internal class CommentConfig : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("T_Comments");
            builder.Property(a => a.Message).IsUnicode().IsRequired();
            // 我有一個TheArticle屬性對應到很多Article的Comments屬性，然後TheArticle屬性是必須的
            builder.HasOne<Article>(c => c.TheArticle)
                .WithMany(a => a.Comments)
                .HasForeignKey(c => c.TheArticleId)
                .IsRequired();

        }
    }
}
