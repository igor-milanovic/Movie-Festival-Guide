using MFG.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.DataAccess.Configurations
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(30);

            builder.Property(x => x.Year).HasMaxLength(4).IsRequired();

            builder.Property(x => x.AvgRating).HasMaxLength(4).IsRequired();

            builder.Property(x => x.Length).IsRequired().HasMaxLength(4);

            builder.HasMany(x => x.MovieDirectors).WithOne(x => x.Movie).HasForeignKey(x => x.MovieID).OnDelete(DeleteBehavior.Restrict);

            //prebaceno iz projection
            builder.HasMany(x => x.Projections).WithOne(x => x.Movie).HasForeignKey(x => x.MovieID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}