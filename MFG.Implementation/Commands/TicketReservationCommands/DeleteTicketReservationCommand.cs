using MFG.Application.Commands.TicketReservationCommands;
using MFG.Application.Exceptions;
using MFG.DataAccess;
using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.TicketReservationCommands
{
    public class DeleteTicketReservationCommand : IDeleteTicketReservationCommand
    {
        private readonly MFGContext _context;

        public DeleteTicketReservationCommand(MFGContext context)
        {
            _context = context;
        }

        public int Id => 1102;

        public string Name => "Delete Ticket Reservation";

        public void Execute(int request)
        {
            var ticket = _context.TicketReservations.Find(request);

            if (ticket == null)
            {
                throw new EntityNotFoundException(request, typeof(TicketReservation));
            }

            ticket.DeletedAt = DateTime.UtcNow;
            ticket.IsActive = false;

            _context.SaveChanges();
        }
    }
}