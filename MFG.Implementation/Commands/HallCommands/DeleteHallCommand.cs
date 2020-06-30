using MFG.Application.Commands.HallCommands;
using MFG.Application.Exceptions;
using MFG.DataAccess;
using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.HallCommands
{
    public class DeleteHallCommand : IDeleteHallCommand
    {
        private readonly MFGContext _context;

        public DeleteHallCommand(MFGContext context)
        {
            _context = context;
        }

        public int Id => 142;

        public string Name => "Delete Hall";

        public void Execute(int request)
        {
            var hall = _context.Halls.Find(request);

            if (hall == null)
            {
                throw new EntityNotFoundException(request, typeof(Hall));
            }

            hall.DeletedAt = DateTime.UtcNow;
            hall.IsActive = false;

            _context.SaveChanges();
        }
    }
}