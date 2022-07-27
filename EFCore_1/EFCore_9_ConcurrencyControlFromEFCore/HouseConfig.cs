﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_9_ConcurrencyControlFromEFCore
{
    internal class HouseConfig : IEntityTypeConfiguration<House>
    {
        public void Configure(EntityTypeBuilder<House> builder)
        {
            builder.ToTable("T_Houses");
            builder.Property(b => b.Name).IsRequired();
            builder.Property(b => b.Owner).IsConcurrencyToken();
        }
    }
}
