using MFG.Application.Commands.PlaceCommands;
using MFG.Application.Exceptions;
using MFG.DataAccess;
using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.PlaceCommands
{
    public class DeletePlaceCommand : IDeletePlaceCommand
    {
        private readonly MFGContext _context;

        public DeletePlaceCommand(MFGContext context)
        {
            _context = context;
        }

        public int Id => 172;

        public string Name => "Delete Place";

        public void Execute(int request)
        {
            var place = _context.Places.Find(request);

            if (place == null)
            {
                throw new EntityNotFoundException(request, typeof(Place));
            }

            place.DeletedAt = DateTime.UtcNow;
            place.IsActive = false;

            _context.SaveChanges();
        }
    }
}