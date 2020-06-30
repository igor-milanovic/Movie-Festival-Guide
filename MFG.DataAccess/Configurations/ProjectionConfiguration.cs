using MFG.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.DataAccess.Configurations
{
    public class ProjectionConfiguration : IEntityTypeConfiguration<Projection>
    {
        public void Configure(EntityTypeBuilder<Projection> builder)
        {
            builder.Property(x => x.BeginsAt).IsRequired();

            //prebaceno u movie
            //builder.HasOne(x => x.Movie).WithMany(x => x.Projections).HasForeignKey(x => x.MovieID).OnDelete(DeleteBehavior.Restrict);

            //prebaceno u hall
            //builder.HasOne(x => x.Hall).WithMany().OnDelete(DeleteBehavior.Restrict);

            //prebaceno iz ticket
            builder.HasMany(x => x.Tickets).WithOne(x => x.Projection).HasForeignKey(x => x.ProjectionID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}