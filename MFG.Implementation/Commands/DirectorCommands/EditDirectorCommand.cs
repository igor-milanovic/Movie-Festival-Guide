using AutoMapper;
using FluentValidation;
using MFG.Application.Commands.DirectorCommands;
using MFG.Application.DataTransfer;
using MFG.Application.Exceptions;
using MFG.DataAccess;
using MFG.Domain;
using MFG.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.DirectorCommands
{
    public class EditDirectorCommand : IEditDirectorCommand
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;
        private readonly DirectorValidator _validator;

        public EditDirectorCommand(MFGContext context, IMapper mapper, DirectorValidator validator)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
        }

        public int Id => 123;

        public string Name => "Edit director";

        public void Execute(DirectorDto request)
        {
            var director = _context.Directors.Find(request.Id);

            if (director == null)
            {
                throw new EntityNotFoundException(request.Id, typeof(Director));
            }

            _validator.ValidateAndThrow(request);

            _mapper.Map(request, director);

            _context.SaveChanges();
        }
    }
}