using AutoMapper;
using FluentValidation;
using MFG.Application.Commands.MovieCommands;
using MFG.Application.DataTransfer;
using MFG.Application.Exceptions;
using MFG.DataAccess;
using MFG.Domain;
using MFG.Implementation.Validators;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MFG.Implementation.Commands.MovieCommands
{
    public class EditMovieCommand : IEditMovieCommand
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;
        private readonly MovieValidator _validator;

        public EditMovieCommand(MFGContext context, IMapper mapper, MovieValidator validator)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
        }

        public int Id => 161;

        public string Name => "Edit Movie";

        public void Execute(MovieDto request)
        {
            var movie = _context.Movies.Include(x => x.MovieDirectors).Where(x => x.Id == request.Id).FirstOrDefault();//Find(request.Id);

            if (movie == null)
            {
                throw new EntityNotFoundException(request.Id, typeof(Movie));
            }

            _validator.ValidateAndThrow(request);

            _mapper.Map(request, movie);

            var mds = movie.MovieDirectors;

            _context.MovieDirector.RemoveRange(mds);  // brisem stare konekcije zbog dupliranja

            ICollection<MovieDirector> MovieDirectors = new HashSet<MovieDirector>();

            foreach (var md in request.Directors)
            {
                MovieDirectors.Add(new MovieDirector
                {
                    DirectorID = md,
                    Movie = movie
                });
            }

            movie.MovieDirectors = MovieDirectors;

            _context.SaveChanges();
        }
    }
}