using MFG.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.DataAccess.Configurations
{
    public class HallConfiguration : IEntityTypeConfiguration<Hall>
    {
        public void Configure(EntityTypeBuilder<Hall> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(30);

            builder.Property(x => x.NumberOfSeats).IsRequired();

            //  prebaceno u location
            //builder.HasOne(x => x.Location).WithMany(x => x.Halls).HasForeignKey(x => x.LocationID).OnDelete(DeleteBehavior.Restrict);

            //prebaceno iz projection
            builder.HasMany(x => x.Projections).WithOne(x => x.Hall).HasForeignKey(x => x.HallID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}