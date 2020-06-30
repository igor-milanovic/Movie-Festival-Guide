using AutoMapper;
using FluentValidation;
using MFG.Application.Commands.ProjectionCommands;
using MFG.Application.DataTransfer;
using MFG.DataAccess;
using MFG.Domain;
using MFG.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.ProjectionCommand
{
    public class CreateProjectionCommand : ICreateProjectionCommand
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;
        private readonly ProjectionValidator _validator;

        public CreateProjectionCommand(MFGContext context, IMapper mapper, ProjectionValidator validator)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
        }

        public int Id => 181;

        public string Name => "Create Projection";

        public void Execute(ProjectionDto request)
        {
            _validator.ValidateAndThrow(request);

            var projection = _mapper.Map<Projection>(request);

            _context.Projections.Add(projection);

            _context.SaveChanges();
        }
    }
}