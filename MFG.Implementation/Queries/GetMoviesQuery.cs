using AutoMapper;
using MFG.Application.DataTransfer;
using MFG.Application.Queries;
using MFG.Application.Searches;
using MFG.DataAccess;
using MFG.Domain;
using MFG.Implementation.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFG.Implementation.Queries
{
    public class GetMoviesQuery : IGetMoviesQuery
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;

        public GetMoviesQuery(MFGContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Id => 261;

        public string Name => "Movies search";

        public PagedResponse<MovieQueryDto> Execute(MovieSearch search)
        {
            var query = _context.Movies.AsQueryable();

            if (!string.IsNullOrEmpty(search.Name) && !string.IsNullOrWhiteSpace(search.Name))
            {
                query = query.Where(x => x.Name.ToLower().Contains(search.Name.ToLower()));
            }

            if (search.RatingAbove is float)
            {
                query = query.Where(x => x.AvgRating > search.RatingAbove);
            }

            if (search.Year is int)
            {
                query = query.Where(x => x.Year == search.Year);
            }

            return query.Paged<MovieQueryDto, Movie>(search, _mapper);
        }
    }
}