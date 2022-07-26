using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_5_selfReferenceStruct
{
    internal class OrgUnitConfig : IEntityTypeConfiguration<OrgUnit>
    {
        public void Configure(EntityTypeBuilder<OrgUnit> builder)
        {
            builder.ToTable("T_OrgUnits");
            builder.Property(o => o.Name).IsUnicode().IsRequired().HasMaxLength(50);
            // 跟節點沒有parent，因此者個關係不能為空
            builder.HasOne(o => o.Parent).WithMany(o => o.Children);
        }
    }
}
