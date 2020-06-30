using AutoMapper;
using FluentValidation;
using MFG.Application.Commands.TicketCommands;
using MFG.Application.DataTransfer;
using MFG.Application.Exceptions;
using MFG.DataAccess;
using MFG.Domain;
using MFG.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.TicketCommands
{
    public class EditTicketCommand : IEditTicketCommand
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;
        private readonly TicketValidator _validator;

        public EditTicketCommand(MFGContext context, IMapper mapper, TicketValidator validator)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
        }

        public int Id => 193;

        public string Name => "Edit Ticket";

        public void Execute(TicketDto request)
        {
            var ticket = _context.Tickets.Find(request.Id);

            if (ticket == null)
            {
                throw new EntityNotFoundException(request.Id, typeof(Ticket));
            }

            _validator.ValidateAndThrow(request);

            _mapper.Map(request, ticket);

            _context.SaveChanges();
        }
    }
}