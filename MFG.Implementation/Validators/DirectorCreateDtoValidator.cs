using FluentValidation;
using MFG.Application.DataTransfer;
using MFG.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFG.Implementation.Validators
{
    public class DirectorCreateDtoValidator : AbstractValidator<DirectorCreateDto>
    {
        private readonly MFGContext _context;

        public DirectorCreateDtoValidator(MFGContext context)
        {
            _context = context;
            string tmp = "";
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("First name is required")
                .MinimumLength(2)
                .WithMessage("First name must have at least 2 characters")
                .MaximumLength(20)
                .WithMessage("Maximu length for first name is 20");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("First name is required")
                .MinimumLength(2)
                .WithMessage("First name must have at least 2 characters")
                .MaximumLength(20)
                .WithMessage("Maximu length for first name is 25");

            RuleFor(x => x.FirstName)
                .Must(n =>
                {
                    if (_context.Directors.Any(x => x.FirstName.ToLower() == n))
                    {
                        tmp = n;
                    }
                    return true;
                });

            if (tmp != "")
            {
                RuleFor(x => x.LastName)
                 .Must(ln => !_context.Directors.Any(x => x.LastName.ToLower() == ln.ToLower()))
                 .WithMessage("Director with that first name and last name already exists");
            }
        }
    }
}