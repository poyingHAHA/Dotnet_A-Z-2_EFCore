using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_4_Relation.OneWayDemoClass
{
    internal class LeaveConfig : IEntityTypeConfiguration<Leave>
    {
        public void Configure(EntityTypeBuilder<Leave> builder)
        {
            builder.ToTable("T_Leaves");
            builder.HasOne<User>(a => a.Requester).WithMany().IsRequired();
            builder.HasOne<User>(b => b.Approver).WithMany();
        }
    }
}
