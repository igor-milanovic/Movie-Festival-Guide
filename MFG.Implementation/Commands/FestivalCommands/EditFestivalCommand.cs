using AutoMapper;
using FluentValidation;
using MFG.Application.Commands.FestivalCommands;
using MFG.Application.DataTransfer;
using MFG.Application.Exceptions;
using MFG.DataAccess;
using MFG.Domain;
using MFG.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.FestivalCommands
{
    public class EditFestivalCommand : IEditFestivalCommand
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;
        private readonly EditFestivalValidator _validator;

        public EditFestivalCommand(MFGContext context, IMapper mapper, EditFestivalValidator validator)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
        }

        public int Id => 133;

        public string Name => "Edit festival";

        public void Execute(EditFestivalDto request)
        {
            var festival = _context.Festivals.Find(request.Id);

            if (festival == null)
            {
                throw new EntityNotFoundException(request.Id, typeof(Festival));
            }

            _validator.ValidateAndThrow(request);

            _mapper.Map(request, festival);

            _context.SaveChanges();
        }
    }
}