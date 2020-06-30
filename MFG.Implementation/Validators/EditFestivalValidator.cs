using FluentValidation;
using MFG.Application.DataTransfer;
using MFG.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFG.Implementation.Validators
{
    public class EditFestivalValidator : AbstractValidator<EditFestivalDto>
    {
        private readonly MFGContext _context;

        public EditFestivalValidator(MFGContext context)
        {
            _context = context;

            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Name is required")
                .MinimumLength(3)
                .WithMessage("Name must have at least 3 characters")
                .MaximumLength(30)
                .WithMessage("Maximu length for name is 30");

            RuleFor(x => x.MaxTickets)
                .NotEmpty()
                 .WithMessage("Maximum number if tickets is required")
                 .ExclusiveBetween(1, 50)
                 .WithMessage("Maximum number if tickets must be between 1 and 50");

            RuleFor(x => x.StartDate)
                .NotNull()
                .WithMessage("StartDate is required")
                .GreaterThanOrEqualTo(DateTime.Now)
                .WithMessage("You can't add festivals in past!");

            RuleFor(x => x.EndDate)
                .NotNull()
                .WithMessage("EndDate is required")
                .GreaterThanOrEqualTo(DateTime.Now)
                .WithMessage("You can't add festivals that ended in the past!")
                .GreaterThan(x => x.StartDate)
                .WithMessage("End date must be after start date!");

            RuleFor(x => x.About)
                .NotNull()
                .WithMessage("About field is required")
                .MinimumLength(30)
                 .WithMessage("About field must have at least 30 characters");

            RuleFor(x => x.PlaceID)
                .NotNull()
                .WithMessage("PlaceID field is required")
                     .Must(p => _context.Places.Any(x => x.Id == p))
                     .WithMessage("PlaceID not valid!")
                 .DependentRules(() =>
                 {
                     RuleFor(x => x.Id)
                     .Must((t, p) => !_context.Festivals.Any(f => f.Name.ToLower() == t.Name.ToLower() && f.StartDate == t.StartDate && f.EndDate == t.EndDate && f.Id != t.Id))
                     .WithMessage("Festival with that name, start and end time already exists!");
                 });
        }
    }
}