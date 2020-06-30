using MFG.Application.Commands.ProjectionCommands;
using MFG.Application.Exceptions;
using MFG.DataAccess;
using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.ProjectionCommand
{
    public class DeleteProjectionCommand : IDeleteProjectionCommand
    {
        private readonly MFGContext _context;

        public DeleteProjectionCommand(MFGContext context)
        {
            _context = context;
        }

        public int Id => 182;

        public string Name => "Delete Projection";

        public void Execute(int request)
        {
            var projection = _context.Projections.Find(request);

            if (projection == null)
            {
                throw new EntityNotFoundException(request, typeof(Projection));
            }

            projection.DeletedAt = DateTime.UtcNow;
            projection.IsActive = false;

            _context.SaveChanges();
        }
    }
}