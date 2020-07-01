using AutoMapper;
using FluentValidation;
using MFG.Application.Commands.HallCommands;
using MFG.Application.DataTransfer;
using MFG.DataAccess;
using MFG.Domain;
using MFG.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.HallCommands
{
    public class CreateHallCommand : ICreateHallCommand
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;
        private readonly HallCreateDtoValidator _validator;

        public CreateHallCommand(MFGContext context, IMapper mapper, HallCreateDtoValidator validator)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
        }

        public int Id => 141;

        public string Name => "Create Hall";

        public void Execute(HallCreateDto request)
        {
            _validator.ValidateAndThrow(request);

            var hall = _mapper.Map<Hall>(request);

            _context.Halls.Add(hall);

            _context.SaveChanges();
        }
    }
}