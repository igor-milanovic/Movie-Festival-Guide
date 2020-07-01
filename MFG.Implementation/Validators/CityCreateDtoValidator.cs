using FluentValidation;
using MFG.Application.DataTransfer;
using MFG.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFG.Implementation.Validators
{
    public class CityCreateDtoValidator : AbstractValidator<CityCreateDto>
    {
        private readonly MFGContext _context;

        public CityCreateDtoValidator(MFGContext context)
        {
            _context = context;

            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("City name is required")
                .MinimumLength(3)
                .WithMessage("City name must have at least 3 characters")
                .MaximumLength(20)
                .WithMessage("City name can have maximum 20 characters")
                .DependentRules(() =>
                {
                    RuleFor(x => x.Name)
                    .Must(n => !_context.Cities.Any(x => x.Name.ToLower() == n.ToLower()))
                    .WithMessage("City name must be unique");
                });
        }
    }
}