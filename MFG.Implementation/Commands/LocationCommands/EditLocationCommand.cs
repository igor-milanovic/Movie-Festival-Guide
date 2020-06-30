using AutoMapper;
using FluentValidation;
using MFG.Application.Commands.LocationCommands;
using MFG.Application.DataTransfer;
using MFG.Application.Exceptions;
using MFG.DataAccess;
using MFG.Domain;
using MFG.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.LocationCommands
{
    public class EditLocationCommand : IEditLocationCommand
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;
        private readonly LocationValidator _validator;

        public EditLocationCommand(MFGContext context, IMapper mapper, LocationValidator validator)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
        }

        public int Id => 153;

        public string Name => "Edit Location";

        public void Execute(LocationDto request)
        {
            var location = _context.Locations.Find(request.Id);

            if (location == null)
            {
                throw new EntityNotFoundException(request.Id, typeof(Location));
            }

            _validator.ValidateAndThrow(request);

            _mapper.Map(request, location);

            _context.SaveChanges();
        }
    }
}