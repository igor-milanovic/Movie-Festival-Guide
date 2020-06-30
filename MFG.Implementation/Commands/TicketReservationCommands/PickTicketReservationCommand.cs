using AutoMapper;
using FluentValidation;
using MFG.Application.Commands.TicketReservationCommands;
using MFG.Application.DataTransfer;
using MFG.Application.Exceptions;
using MFG.DataAccess;
using MFG.Domain;
using MFG.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MFG.Implementation.Commands.TicketReservationCommands
{
    public class PickTicketReservationCommand : IPickTicketReservationCommand
    {
        private readonly MFGContext _context;
        private readonly BuyTicketReservationValidator _validator;

        public PickTicketReservationCommand(MFGContext context, BuyTicketReservationValidator validator)
        {
            _context = context;
            _validator = validator;
        }

        public int Id => 1104;

        public string Name => "Pick Ticket Reservation";

        public void Execute(int request)
        {
            var ticket = _context.TicketReservations.Find(request);

            if (ticket == null)
            {
                throw new EntityNotFoundException(request, typeof(TicketReservation));
            }

            _validator.ValidateAndThrow(request);

            ticket.Bought = DateTime.UtcNow;

            _context.SaveChanges();
        }
    }
}