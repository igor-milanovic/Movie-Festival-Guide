using AutoMapper;
using FluentValidation;
using MFG.Application;
using MFG.Application.Commands.CityCommands;
using MFG.Application.DataTransfer;
using MFG.Application.Exceptions;
using MFG.DataAccess;
using MFG.Domain;
using MFG.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.CityCommands
{
    public class EditCityCommand : IEditCityCommand
    {
        private readonly MFGContext _context;
        private readonly EditCityValidator _validator;
        private readonly IMapper _mapper;

        public EditCityCommand(MFGContext context, EditCityValidator validator, IMapper mapper)
        {
            _context = context;
            _validator = validator;
            _mapper = mapper;
        }

        public int Id => 113;

        public string Name => "Edit City";

        public void Execute(EditCityDto request)
        {
            var city = _context.Cities.Find(request.Id);

            if (city == null)
            {
                throw new EntityNotFoundException(request.Id, typeof(City));
            }

            _validator.ValidateAndThrow(request);

            var newCity = _mapper.Map<City>(request);

            _mapper.Map(request, city);

            _context.SaveChanges();
        }
    }
}