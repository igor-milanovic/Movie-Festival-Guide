using MFG.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.DataAccess.Configurations
{
    public class DirectorConfiguration : IEntityTypeConfiguration<Director>
    {
        public void Configure(EntityTypeBuilder<Director> builder)
        {
            builder.Property(x => x.FirstName).HasMaxLength(20).IsRequired();

            builder.Property(x => x.LastName).IsRequired().HasMaxLength(25);

            builder.HasMany(x => x.MovieDirectors).WithOne(x => x.Director).HasForeignKey(x => x.DirectorID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}