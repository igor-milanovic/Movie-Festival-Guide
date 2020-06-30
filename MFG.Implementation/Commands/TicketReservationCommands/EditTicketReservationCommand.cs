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
using System.Text;

namespace MFG.Implementation.Commands.TicketReservationCommands
{
    public class EditTicketReservationCommand : IEditTicketReservationCommand
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;
        private readonly TicketReservationValidator _validator;

        public EditTicketReservationCommand(MFGContext context, IMapper mapper, TicketReservationValidator validator)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
        }

        public int Id => 1103;

        public string Name => "Edit Ticket Reservation";

        public void Execute(TicketReservationDto request)
        {
            var ticket = _context.TicketReservations.Find(request.Id);

            if (ticket == null)
            {
                throw new EntityNotFoundException(request.Id, typeof(TicketReservation));
            }

            _validator.ValidateAndThrow(request);

            _mapper.Map(request, ticket);

            _context.SaveChanges();
        }
    }
}