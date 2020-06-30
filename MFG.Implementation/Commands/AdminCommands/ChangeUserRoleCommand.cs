using FluentValidation;
using MFG.Application.Commands.AdminCommands;
using MFG.Application.DataTransfer;
using MFG.Application.Exceptions;
using MFG.DataAccess;
using MFG.Domain;
using MFG.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.AdminCommands
{
    public class ChangeUserRoleCommand : IChangeUserRoleCommand
    {
        private readonly MFGContext _context;
        private readonly UserRoleValidator _validator;

        public ChangeUserRoleCommand(MFGContext context, UserRoleValidator validator)
        {
            _context = context;
            _validator = validator;
        }

        public int Id => 1121;

        public string Name => "Change User Role";

        public void Execute(UserRoleDto request)
        {
            var user = _context.Users.Find(request.Id);

            if (user == null)
            {
                throw new EntityNotFoundException(request.Id, typeof(User));
            }

            _validator.ValidateAndThrow(request);

            user.RoleID = request.RoleID;

            _context.SaveChanges();
        }
    }
}