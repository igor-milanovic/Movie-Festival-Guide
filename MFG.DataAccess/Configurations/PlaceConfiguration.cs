using MFG.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.DataAccess.Configurations
{
    public class PlaceConfiguration : IEntityTypeConfiguration<Place>
    {
        public void Configure(EntityTypeBuilder<Place> builder)
        {
            //builder.HasAlternateKey(x => new { x.CityID, x.LocationID });
            builder.HasIndex(x => new { x.CityID, x.LocationID }).IsUnique();

            //builder.HasOne(x => x.City).WithOne().OnDelete(DeleteBehavior.Restrict);

            // bilo ovako builder.HasOne(x => x.City).WithMany().OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.City).WithMany().OnDelete(DeleteBehavior.Restrict);
            // ovo ne radi? builder.HasOne(x => x.City).WithOne(x => x.Place).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Location).WithOne().OnDelete(DeleteBehavior.Restrict);

            //prebaceno iz festival
            builder.HasMany(x => x.Festivals).WithOne(x => x.Place).HasForeignKey(x => x.PlaceID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}