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
        private readonly TicketReservationValidator _validator;

        public CreateTicketReservationCommand(MFGContext context, IMapper mapper, TicketReservationValidator validator)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
        }

        public int Id => 1101;

        public string Name => "Create Ticket Reservation";
        //public decimal TotalPrice { get; set; }    //ja racunam!!

        //public DateTime ReservationDate { get; set; }  //user ne vidi i ne unosi se s polja
        //public DateTime? Bought { get; set; }  //user ne vidi i ne unosi se s polja
        //public string ReservationCode { get; set; }  //user ne vidi i ne unosi se s polja
        public void Execute(TicketReservationDto request)
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