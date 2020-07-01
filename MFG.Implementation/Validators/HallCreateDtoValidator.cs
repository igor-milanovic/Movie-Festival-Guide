using FluentValidation;
using MFG.Application.DataTransfer;
using MFG.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFG.Implementation.Validators
{
    public class HallCreateDtoValidator : AbstractValidator<HallCreateDto>
    {
        private readonly MFGContext _context;

        public HallCreateDtoValidator(MFGContext context)
        {
            _context = context;

            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Name field is required")
                .MinimumLength(3)
                .WithMessage("Name field must have at least 3 characters")
                .MaximumLength(30)
                .WithMessage("Name field can have maximum 30 characters");

            RuleFor(x => x.NumberOfSeats)
                 .NotEmpty()
                 .WithMessage("NumberOfSeats field is required")
                 .InclusiveBetween(10, 90000)
                 .WithMessage("NumberOfSeats must be between 10 and 90000");

            RuleFor(x => x.LocationID)
                .NotNull()
                .WithMessage("LocationID field is required")
                .Must(p => _context.Locations.Any(x => x.Id == p))
                .WithMessage("LocationID not valid!")
                .DependentRules(() =>
                {
                    RuleFor(x => x.Name)
                    .Must((h, n) => !_context.Halls.Any(x => x.Name.ToLower() == h.Name.ToLower() && x.LocationID == h.LocationID))
                    .WithMessage("There is allready hall with that name in that location");
                });
        }
    }
}