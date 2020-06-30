using MFG.Application.Commands.LocationCommands;
using MFG.Application.Exceptions;
using MFG.DataAccess;
using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.LocationCommands
{
    public class DeleteLocationCommand : IDeleteLocationCommand
    {
        private readonly MFGContext _context;

        public DeleteLocationCommand(MFGContext context)
        {
            _context = context;
        }

        public int Id => 152;

        public string Name => "Delete Location";

        public void Execute(int request)
        {
            var location = _context.Locations.Find(request);

            if (location == null)
            {
                throw new EntityNotFoundException(request, typeof(Location));
            }

            location.DeletedAt = DateTime.UtcNow;
            location.IsActive = false;

            _context.SaveChanges();
        }
    }
}