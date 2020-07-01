using AutoMapper;
using FluentValidation;
using MFG.Application.Commands.TicketReservationCommands;
using MFG.Application.DataTransfer;
using MFG.DataAccess;
using MFG.DataAccess.DBHelperClasses;
using MFG.Domain;
using MFG.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.TicketReservationCommands
{
    public class CreateTicketReservationCommand : ICreateTicketReservationCommand
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;
        private readonly TicketReservationCreateDtoValidator _validator;

        public CreateTicketReservationCommand(MFGContext context, IMapper mapper, TicketReservationCreateDtoValidator validator)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
        }

        public int Id => 1101;

        public string Name => "Create Ticket Reservation";

        public void Execute(TicketReservationCreateDto request)
        {
            _validator.ValidateAndThrow(request);

            var ticket = _mapper.Map<TicketReservation>(request);

            ticket.ReservationDate = DateTime.UtcNow;

            ticket.Bought = null;

            var helper = new AddFakeData();

            ticket.ReservationCode = helper.GenerateReservationCode();

            _context.TicketReservations.Add(ticket);

            _context.SaveChanges();
        }
    }
}