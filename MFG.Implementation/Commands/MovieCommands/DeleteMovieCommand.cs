using MFG.Application.Commands.MovieCommands;
using MFG.Application.Exceptions;
using MFG.DataAccess;
using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.MovieCommands
{
    public class DeleteMovieCommand : IDeleteMovieCommand
    {
        private readonly MFGContext _context;

        public DeleteMovieCommand(MFGContext context)
        {
            _context = context;
        }

        public int Id => 162;

        public string Name => "Delete Movie";

        public void Execute(int request)
        {
            var movie = _context.Movies.Find(request);

            if (movie == null)
            {
                throw new EntityNotFoundException(request, typeof(Movie));
            }

            movie.DeletedAt = DateTime.UtcNow;
            movie.IsActive = false;

            // da li da brisem i veznu tabelu?

            _context.SaveChanges();
        }
    }
}