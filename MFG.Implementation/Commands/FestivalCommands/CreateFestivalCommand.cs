using AutoMapper;
using FluentValidation;
using MFG.Application.Commands.FestivalCommands;
using MFG.Application.DataTransfer;
using MFG.DataAccess;
using MFG.Domain;
using MFG.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.FestivalCommands
{
    public class CreateFestivalCommand : ICreateFestivalCommand
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;
        private readonly FestivalCreateDtoValidator _validator;

        public CreateFestivalCommand(MFGContext context, IMapper mapper, FestivalCreateDtoValidator validator)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
        }

        public int Id => 131;

        public string Name => "Create Festival";

        public void Execute(FestivalCreateDto request)
        {
            _validator.ValidateAndThrow(request);

            var festival = _mapper.Map<Festival>(request);

            _context.Festivals.Add(festival);

            _context.SaveChanges();
        }
    }
}