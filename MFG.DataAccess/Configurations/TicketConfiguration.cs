using MFG.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.DataAccess.Configurations
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.Property(x => x.Price).HasMaxLength(10).IsRequired();

            //prebaceno u festival
            //builder.HasOne(x => x.Festival).WithMany().OnDelete(DeleteBehavior.Restrict);

            //prebaceno u Projection
            //builder.HasOne(x => x.Projection).WithMany().OnDelete(DeleteBehavior.Restrict);

            //prebaceno iz TicketReservations
            builder.HasMany(x => x.TicketReservations).WithOne(x => x.Ticket).HasForeignKey(x => x.TicketID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}