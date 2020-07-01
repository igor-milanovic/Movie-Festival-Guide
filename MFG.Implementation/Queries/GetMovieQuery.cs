using AutoMapper;
using MFG.Application.DataTransfer;
using MFG.Application.Queries;
using MFG.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFG.Implementation.Queries
{
    public class GetMovieQuery : IGetMovieQuery
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;

        public GetMovieQuery(MFGContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Id => 262;

        public string Name => "Movies search by id";

        public MovieDto Execute(int search)
        {
            var query = _context.Movies.Include(x => x.MovieDirectors).Where(x => x.Id == search).FirstOrDefault();

            return _mapper.Map<MovieDto>(query);
        }
    }
}