using AutoMapper;
using FluentValidation;
using MFG.Application.Commands.ProjectionCommands;
using MFG.Application.DataTransfer;
using MFG.Application.Exceptions;
using MFG.DataAccess;
using MFG.Domain;
using MFG.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.ProjectionCommand
{
    public class EditProjectionCommand : IEditProjectionCommand
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;
        private readonly ProjectionValidator _validator;

        public EditProjectionCommand(MFGContext context, IMapper mapper, ProjectionValidator validator)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
        }

        public int Id => 183;

        public string Name => "Edit Projection";

        public void Execute(ProjectionDto request)
        {
            var projection = _context.Projections.Find(request.Id);

            if (projection == null)
            {
                throw new EntityNotFoundException(request.Id, typeof(Projection));
            }

            _validator.ValidateAndThrow(request);

            _mapper.Map(request, projection);

            _context.SaveChanges();
        }
    }
}