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
using System.Text;

namespace MFG.Implementation.Queries
{
    public class GetCitiesQuery : IGetCitiesQuery
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;

        public GetCitiesQuery(MFGContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Id => 211;

        public string Name => "City search";

        public PagedResponse<CityQueryDto> Execute(CitySearch search)
        {
            var query = _context.Cities.Include(x => x.Locations).AsQueryable();

            if (!string.IsNullOrEmpty(search.Name) || !string.IsNullOrWhiteSpace(search.Name))
            {
                query = query.Where(x => x.Name.ToLower().Contains(search.Name.ToLower()));
            }

            return query.Paged<CityQueryDto, City>(search, _mapper);
        }
    }
}