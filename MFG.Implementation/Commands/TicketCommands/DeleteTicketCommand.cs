using MFG.Application.Commands.TicketCommands;
using MFG.Application.Exceptions;
using MFG.DataAccess;
using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.TicketCommands
{
    public class DeleteTicketCommand : IDeleteTicketCommand
    {
        private readonly MFGContext _context;

        public DeleteTicketCommand(MFGContext context)
        {
            _context = context;
        }

        public int Id => 192;

        public string Name => "Delete Ticket";

        public void Execute(int request)
        {
            var ticket = _context.Tickets.Find(request);

            if (ticket == null)
            {
                throw new EntityNotFoundException(request, typeof(Ticket));
            }

            ticket.DeletedAt = DateTime.UtcNow;
            ticket.IsActive = false;

            _context.SaveChanges();
        }
    }
}