using FluentValidation;
using MFG.Application.DataTransfer;
using MFG.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFG.Implementation.Validators
{
    public class UserCreateDtoValidator : AbstractValidator<UserCreateDto>
    {
        private readonly MFGContext _context;

        public UserCreateDtoValidator(MFGContext context)
        {
            _context = context;

            RuleFor(x => x.FirstName)
               .NotEmpty()
               .WithMessage("First name is required")
               .MinimumLength(3)
               .WithMessage("First name must have at least 3 characters")
               .MaximumLength(30)
               .WithMessage("First name can have maximum 30 characters");

            RuleFor(x => x.LastName)
              .NotEmpty()
              .WithMessage("Last name name is required")
              .MinimumLength(2)
              .WithMessage("Last name must have at least 2 characters")
              .MaximumLength(40)
              .WithMessage("Last name can have maximum 40 characters");

            RuleFor(x => x.Email)
              .NotEmpty()
              .WithMessage("Email is required")
              .EmailAddress()
              .WithMessage("Email must me in email fomat...")
              .MaximumLength(50)
              .WithMessage("Email can have maximum 50 characters")
              .DependentRules(() =>
              {
                  RuleFor(x => x.Email)
                  .Must((e, n) => !_context.Users.Any(x => x.Email.ToLower() == n.ToLower()))
                  .WithMessage("Email  must be unique");
              });

            RuleFor(x => x.Username)
                .NotEmpty()
                .WithMessage("Username is required")
                .MinimumLength(3)
                .WithMessage("Username must have at least 3 characters")
                .MaximumLength(30)
                .WithMessage("Username can have maximum 30 characters")
                .DependentRules(() =>
                {
                    RuleFor(x => x.Username)
                    .Must((u, n) => !_context.Users.Any(x => x.Username.ToLower() == n.ToLower()))
                    .WithMessage("Username  must be unique");
                });

            RuleFor(x => x.Password)
              .NotEmpty()
              .WithMessage("Password is required")
              .MinimumLength(3)
              .WithMessage("Password must have at least 3 characters")
              .MaximumLength(30)
              .WithMessage("Password can have maximum 30 characters");
        }
    }
}