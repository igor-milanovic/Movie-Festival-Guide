using FluentValidation;
using MFG.Application.DataTransfer;
using MFG.DataAccess;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MFG.Implementation.Validators
{
    public class UserRoleValidator : AbstractValidator<UserRoleDto>
    {
        private readonly MFGContext _context;

        public UserRoleValidator(MFGContext context)
        {
            _context = context;

            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("UserID is required")
                .Must(x => _context.Users.Any(u => u.Id == x))
                .WithMessage("User ID not valid");

            RuleFor(x => x.RoleID)
                 .NotEmpty()
                 .WithMessage("RoleID is required")
                 .InclusiveBetween(1, 2)
                 .WithMessage("RoleID can be 1(regular user) or 2 (seller)")
                 .Must((y, x) =>
                 {
                     return !(_context.Users.Find(y.Id).RoleID == 3); // admin poskua da promeni ulogu drugom adminu
                 })
                 .WithMessage("You don't have permition to change another admin's role!");
        }
    }
}