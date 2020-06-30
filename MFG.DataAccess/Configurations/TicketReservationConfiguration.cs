using MFG.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFG.DataAccess.Configurations
{
    public class TicketReservationConfiguration : IEntityTypeConfiguration<TicketReservation>
    {
        public void Configure(EntityTypeBuilder<TicketReservation> builder)
        {
            builder.Property(x => x.ReservationDate).IsRequired().HasDefaultValue(DateTime.UtcNow);

            builder.Property(x => x.Quantity).HasMaxLength(3).IsRequired();

            builder.Property(x => x.TotalPrice).IsRequired().HasMaxLength(20);

            builder.Property(x => x.ReservationCode).IsRequired().HasMaxLength(10);
            builder.HasIndex(x => x.ReservationCode).IsUnique();

            // prebaceno u user
            //builder.HasOne(x => x.User).WithMany(x => x.TicketReservations).OnDelete(DeleteBehavior.Restrict);

            // prebaceno u ticket
            //builder.HasOne(x => x.Ticket).WithMany().OnDelete(DeleteBehavior.Restrict);
        }
    }
}