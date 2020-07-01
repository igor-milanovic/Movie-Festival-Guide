using FluentValidation;
using MFG.Application.DataTransfer;
using MFG.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFG.Implementation.Validators
{
    public class LocationValidator : AbstractValidator<LocationDto>
    {
        private readonly MFGContext _context;

        public LocationValidator(MFGContext context)
        {
            _context = context;

            RuleFor(x => x.Name)
               .NotEmpty()
               .WithMessage("Name field is required")
               .MinimumLength(3)
               .WithMessage("Name field must have at least 3 characters")
               .MaximumLength(50)
               .WithMessage("Name field can have maximum 50 characters")
                .DependentRules(() =>
                {
                    RuleFor(x => x)
                   .Must(n => !_context.Locations.Any(x => x.Name.ToLower() == n.Name.ToLower() && x.CityID == n.CityID))
                   .WithMessage("Name can be used once per city");
                });

            RuleFor(x => x.CityID)
                .NotNull()
                .WithMessage("CityID field is required")
                .Must(p => _context.Cities.Any(x => x.Id == p))
                .WithMessage("CityID not valid!");
            /*      da li mi halls trebaju u locationu?
            RuleForEach(x => x.Halls)
                .Must(p => _context.Halls.Any(x => x.Id == p.Id))
                .WithMessage("HallID not valid");
            */

            /*  Mozda ne mora, ako postoji admin panel gde se dodaje prvo mesto, pa se u editovanju tog mesta biraju hallovi
            RuleFor(x => x.Halls)
                .NotEmpty()
                .WithMessage("There must me at least 1 hall!");

            */

            /*
            RuleForEach(x => x.Halls).
                SetValidator(new HallValidator(_context));
            */
        }
    }
}