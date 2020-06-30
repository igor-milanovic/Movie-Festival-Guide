using MFG.Application.Commands.DirectorCommands;
using MFG.Application.Exceptions;
using MFG.DataAccess;
using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.DirectorCommands
{
    public class DeleteDirectorCommand : IDeleteDirectorCommand
    {
        private readonly MFGContext _context;

        public DeleteDirectorCommand(MFGContext context)
        {
            _context = context;
        }

        public int Id => 122;

        public string Name => "Delete Director";

        public void Execute(int request)
        {
            var director = _context.Directors.Find(request);

            if (director == null)
            {
                throw new EntityNotFoundException(request, typeof(City));
            }

            director.DeletedAt = DateTime.UtcNow;
            director.IsActive = false;
            _context.SaveChanges();
        }
    }
}