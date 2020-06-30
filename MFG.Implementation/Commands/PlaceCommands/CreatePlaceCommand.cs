using AutoMapper;
using FluentValidation;
using MFG.Application.Commands.PlaceCommands;
using MFG.Application.DataTransfer;
using MFG.DataAccess;
using MFG.Domain;
using MFG.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.PlaceCommands
{
    public class CreatePlaceCommand : ICreatePlaceCommand
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;
        private readonly PlaceValidator _validator;

        public CreatePlaceCommand(MFGContext context, IMapper mapper, PlaceValidator validator)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
        }

        public int Id => 171;

        public string Name => "Create Place";

        public void Execute(PlaceDto request)
        {
            _validator.ValidateAndThrow(request);

            var place = _mapper.Map<Place>(request);

            _context.Places.Add(place);

            _context.SaveChanges();
        }
    }
}