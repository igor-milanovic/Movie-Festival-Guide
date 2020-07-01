using AutoMapper;
using FluentValidation;
using MFG.Application.Commands.TicketCommands;
using MFG.Application.DataTransfer;
using MFG.DataAccess;
using MFG.Domain;
using MFG.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.TicketCommands
{
    public class CreateTicketCommand : ICreateTicketCommand
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;
        private readonly TicketCreateDtoValidator _validator;

        public CreateTicketCommand(MFGContext context, IMapper mapper, TicketCreateDtoValidator validator)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
        }

        public int Id => 191;

        public string Name => "Create Ticket";

        public void Execute(TicketCreateDto request)
        {
            _validator.ValidateAndThrow(request);

            var ticket = _mapper.Map<Ticket>(request);

            _context.Tickets.Add(ticket);

            _context.SaveChanges();
        }
    }
}