using AutoMapper;
using FluentValidation;
using MFG.Application.Commands.MovieCommands;
using MFG.Application.DataTransfer;
using MFG.DataAccess;
using MFG.Domain;
using MFG.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.MovieCommands
{
    public class CreateMovieCommand : ICreateMovieCommand
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;
        private readonly MovieValidator _validator;

        public CreateMovieCommand(MFGContext context, IMapper mapper, MovieValidator validator)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
        }

        public int Id => 161;

        public string Name => "Create Movie";

        public void Execute(MovieDto request)
        {
            _validator.ValidateAndThrow(request);

            var movie = _mapper.Map<Movie>(request);

            foreach (var md in request.Directors)
            {
                movie.MovieDirectors.Add(new MovieDirector
                {
                    Movie = movie,
                    DirectorID = md
                });
            }

            _context.Movies.Add(movie);

            _context.SaveChanges();
        }
    }
}