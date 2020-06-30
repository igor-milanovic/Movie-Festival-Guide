using AutoMapper;
using MFG.Application.DataTransfer;
using MFG.Application.Queries;
using MFG.Application.Searches;
using MFG.DataAccess;
using MFG.Domain;
using MFG.Implementation.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MFG.Implementation.Queries
{
    public class GetProjectionsQuery : IGetProjectionsQuery
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;

        public GetProjectionsQuery(MFGContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Id => 281;

        public string Name => "Projections search";

        public PagedResponse<ProjectionQueryDto> Execute(ProjectionSearch search)
        {
            var query = _context.Projections.Include(x => x.Movie).Include(x => x.Festival).ThenInclude(x => x.Place).AsQueryable();

            if (!string.IsNullOrEmpty(search.MovieName) && !string.IsNullOrWhiteSpace(search.MovieName))
            {
                query = query.Where(x => x.Movie.Name.ToLower().Contains(search.MovieName.ToLower()));
            }

            if (search.LocationID is int)
            {
                query = query.Where(x => x.Hall.LocationID == search.LocationID);
            }

            if (search.FestivalID is int)
            {
                query = query.Where(x => x.FestivalID == search.FestivalID);
            }

            if (search.HallID is int)
            {
                query = query.Where(x => x.HallID == search.HallID);
            }

            if (search.MovieID is int)
            {
                query = query.Where(x => x.MovieID == search.MovieID);
            }

            return query.Paged<ProjectionQueryDto, Projection>(search, _mapper);
        }
    }
}