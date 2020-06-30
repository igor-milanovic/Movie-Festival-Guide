using AutoMapper;
using FluentValidation;
using MFG.Application.Commands.DirectorCommands;
using MFG.Application.DataTransfer;
using MFG.DataAccess;
using MFG.Domain;
using MFG.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.DirectorCommands
{
    public class CreateDirectorCommand : ICreateDirectorCommand
    {
        private readonly IMapper _mapper;
        private readonly MFGContext _context;
        private readonly DirectorValidator _validator;

        public CreateDirectorCommand(IMapper mapper, MFGContext context, DirectorValidator validator)
        {
            _mapper = mapper;
            _context = context;
            _validator = validator;
        }

        public int Id => 121;

        public string Name => "Create Director";

        public void Execute(DirectorDto request)
        {
            _validator.ValidateAndThrow(request);

            var director = _mapper.Map<Director>(request);

            _context.Directors.Add(director);

            _context.SaveChanges();
        }
    }
}