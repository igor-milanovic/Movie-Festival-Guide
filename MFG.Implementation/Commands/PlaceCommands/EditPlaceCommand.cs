using AutoMapper;
using FluentValidation;
using MFG.Application.Commands.PlaceCommands;
using MFG.Application.DataTransfer;
using MFG.Application.Exceptions;
using MFG.DataAccess;
using MFG.Domain;
using MFG.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.PlaceCommands
{
    public class EditPlaceCommand : IEditPlaceCommand
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;
        private readonly PlaceValidator _validator;

        public EditPlaceCommand(MFGContext context, IMapper mapper, PlaceValidator validator)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
        }

        public int Id => 173;

        public string Name => "Edit Place";

        public void Execute(PlaceDto request)
        {
            var place = _context.Places.Find(request.Id);

            if (place == null)
            {
                throw new EntityNotFoundException(request.Id, typeof(Place));
            }

            _validator.ValidateAndThrow(request);

            _mapper.Map(request, place);

            _context.SaveChanges();
        }
    }
}