using MFG.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.DataAccess.Configurations
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();

            // builder.HasIndex(x => x.Name).IsUnique(); jer dom omladine moze postojati u vise gradova!

            builder.HasMany(x => x.Halls).WithOne(x => x.Location).HasForeignKey(x => x.LocationID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}