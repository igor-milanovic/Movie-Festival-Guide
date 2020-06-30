using MFG.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.DataAccess.Configurations
{
    public class FestivalConfiguration : IEntityTypeConfiguration<Festival>
    {
        public void Configure(EntityTypeBuilder<Festival> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(30).IsRequired();

            builder.Property(x => x.StartDate).IsRequired();

            builder.Property(x => x.EndDate).IsRequired();

            builder.Property(x => x.About).IsRequired().HasColumnType("text");

            builder.Property(x => x.MaxTickets).IsRequired().HasMaxLength(3);

            builder.HasMany(x => x.Projections)
                .WithOne(p => p.Festival)
                .HasForeignKey(x => x.FestivalID)
                .OnDelete(DeleteBehavior.Restrict);

            // builder.HasOne(x => x.Place).WithMany().OnDelete(DeleteBehavior.Restrict); => prebaceno u place

            //prebaceno iz ticket
            builder.HasMany(x => x.Tickets).WithOne(x => x.Festival).HasForeignKey(x => x.FestivalID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}