using AutoMapper;
using FluentValidation;
using MFG.Application.Commands.HallCommands;
using MFG.Application.DataTransfer;
using MFG.Application.Exceptions;
using MFG.DataAccess;
using MFG.Domain;
using MFG.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.HallCommands
{
    public class EditHallCommand : IEditHallCommand
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;
        private readonly HallValidator _validator;

        public EditHallCommand(MFGContext context, IMapper mapper, HallValidator validator)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
        }

        public int Id => 143;

        public string Name => "Edit Hall";

        public void Execute(HallDto request)
        {
            var hall = _context.Halls.Find(request.Id);

            if (hall == null)
            {
                throw new EntityNotFoundException(request.Id, typeof(Hall));
            }
            _validator.ValidateAndThrow(request);

            _mapper.Map(request, hall);

            _context.SaveChanges();
        }
    }
}