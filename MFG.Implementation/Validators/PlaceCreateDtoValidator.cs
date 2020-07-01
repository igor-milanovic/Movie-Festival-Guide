using FluentValidation;
using MFG.Application.DataTransfer;
using MFG.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFG.Implementation.Validators
{
    public class PlaceCreateDtoValidator : AbstractValidator<PlaceCreateDto>
    {
        private readonly MFGContext _context;

        public PlaceCreateDtoValidator(MFGContext context)
        {
            _context = context;

            bool cityId = false;
            bool locationId = false;

            RuleFor(x => x.CityID)
               .NotNull()
               .WithMessage("CityID field is required")
               .DependentRules(() =>
               {
                   RuleFor(x => x.CityID)
                   .Must(p =>
                   {
                       cityId = _context.Cities.Any(x => x.Id == p);
                       return cityId;
                   })
                   .WithMessage("CityID not valid!");
               });

            RuleFor(x => x.LocationID)
               .NotNull()
               .WithMessage("LocationID field is required")
               .DependentRules(() =>
               {
                   RuleFor(x => x.LocationID)
                   .Must(p =>
                   {
                       locationId = _context.Locations.Any(x => x.Id == p);
                       return locationId;
                   })
                   .WithMessage("LocationID not valid!");

                   RuleFor(x => x.LocationID)
                   .Must((p, l) => !_context.Places.Any(x => p.LocationID == x.LocationID))
                   .WithMessage("That location is already taken...  /* moguce neka smislenija poruka*/");

                   RuleFor(x => x.LocationID)
                       .Must((p, i) =>
                       {
                           if (!(locationId && cityId)) return true;
                           var tmp = !_context.Places.Any(x => x.LocationID == p.LocationID && x.CityID == p.CityID);

                           return tmp;
                       })
                       .WithMessage("Place with that location and that city already exists");
               });
        }
    }
}