using AutoMapper;
using FluentValidation;
using MFG.Application.Commands.CityCommands;
using MFG.Application.DataTransfer;
using MFG.DataAccess;
using MFG.Domain;
using MFG.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MFG.Implementation.Commands.CityCommands
{
    public class CreateCityCommand : ICreateCityCommand
    {
        /*
         *  id = xyz
         *  x:  1-command       2-query
         *  y:  class
         *  z:  command num for y-calss
         */

        private readonly MFGContext _context;
        private readonly CityCreateDtoValidator _validator;
        private readonly IMapper _mapper;

        public CreateCityCommand(MFGContext context, CityCreateDtoValidator validator, IMapper mapper)
        {
            _context = context;
            _validator = validator;
            _mapper = mapper;
        }

        public int Id => 111;

        public string Name => "Create New City";

        public void Execute(CityCreateDto request)
        {
            _validator.ValidateAndThrow(request);

            City city = _mapper.Map<City>(request);

            _context.Cities.Add(city);

            _context.SaveChanges();
        }
    }
}