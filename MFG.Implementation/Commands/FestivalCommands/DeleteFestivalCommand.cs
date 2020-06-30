using MFG.Application.Commands.FestivalCommands;
using MFG.Application.Exceptions;
using MFG.DataAccess;
using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.FestivalCommands
{
    public class DeleteFestivalCommand : IDeleteFestivalCommand
    {
        private readonly MFGContext _context;

        public DeleteFestivalCommand(MFGContext context)
        {
            _context = context;
        }

        public int Id => 132;

        public string Name => "Delete Festival";

        public void Execute(int request)
        {
            var festival = _context.Festivals.Find(request);

            if (festival == null)
            {
                throw new EntityNotFoundException(request, typeof(Festival));
            }

            festival.DeletedAt = DateTime.UtcNow;
            festival.IsActive = false;
            _context.SaveChanges();
        }
    }
}