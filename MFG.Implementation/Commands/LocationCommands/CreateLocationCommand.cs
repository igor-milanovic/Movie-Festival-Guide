using AutoMapper;
using FluentValidation;
using MFG.Application.Commands.LocationCommands;
using MFG.Application.DataTransfer;
using MFG.DataAccess;
using MFG.Domain;
using MFG.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.LocationCommands
{
    public class CreateLocationCommand : ICreateLocationCommand

    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;
        private readonly LocationCreateDtoValidator _validator;

        public CreateLocationCommand(MFGContext context, IMapper mapper, LocationCreateDtoValidator validator)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
        }

        public int Id => 151;

        public string Name => "Create Location";

        public void Execute(LocationCreateDto request)
        {
            _validator.ValidateAndThrow(request);

            var location = _mapper.Map<Location>(request);

            _context.Locations.Add(location);

            _context.SaveChanges();
        }
    }
}