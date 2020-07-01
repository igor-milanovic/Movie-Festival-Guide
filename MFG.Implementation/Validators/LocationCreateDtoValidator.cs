using FluentValidation;
using MFG.Application.DataTransfer;
using MFG.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFG.Implementation.Validators
{
    public class LocationCreateDtoValidator : AbstractValidator<LocationCreateDto>
    {
        private readonly MFGContext _context;

        public LocationCreateDtoValidator(MFGContext context)
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
                    /*RuleFor(x => x.Name)
                    .Must(n => !_context.Locations.Any(x => x.Name.ToLower() == n.ToLower()))
                    .WithMessage("Name must be unique! we are working to fix this");*/
                    RuleFor(x => x)
                    .Must(n => !_context.Locations.Any(x => x.Name.ToLower() == n.Name.ToLower() && x.CityID == n.CityID))
                    .WithMessage("Name can be used once per city");
                });

            RuleFor(x => x.CityID)
                .NotNull()
                .WithMessage("CityID field is required")
                .Must(p => _context.Cities.Any(x => x.Id == p))
                .WithMessage("CityID not valid!");
        }
    }
}