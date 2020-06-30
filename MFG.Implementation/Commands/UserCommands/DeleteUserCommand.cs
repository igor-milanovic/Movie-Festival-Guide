using MFG.Application.Commands.UserCommands;
using MFG.Application.Exceptions;
using MFG.DataAccess;
using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.UserCommands
{
    public class DeleteUserCommand : IDeleteUserCommand
    {
        private readonly MFGContext _context;

        public DeleteUserCommand(MFGContext context)
        {
            _context = context;
        }

        public int Id => 1112;

        public string Name => "Delete User";

        public void Execute(int request)
        {
            var user = _context.Users.Find(request);

            if (user == null)
            {
                throw new EntityNotFoundException(request, typeof(User));
            }

            user.DeletedAt = DateTime.UtcNow;
            user.IsActive = false;

            _context.SaveChanges();
        }
    }
}