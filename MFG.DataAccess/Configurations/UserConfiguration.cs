using MFG.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.DataAccess.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.FirstName).HasMaxLength(30).IsRequired();

            builder.Property(x => x.LastName).HasMaxLength(40).IsRequired();

            builder.Property(x => x.Email).IsRequired().HasMaxLength(40);
            builder.HasIndex(x => x.Email).IsUnique();

            builder.Property(x => x.Username).HasMaxLength(30);
            builder.HasIndex(x => x.Username).IsUnique();

            builder.Property(x => x.Password).HasMaxLength(50).IsRequired();

            //prebaceno iz TicketReservations
            builder.HasMany(x => x.TicketReservations).WithOne(x => x.User).HasForeignKey(x => x.UserID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}