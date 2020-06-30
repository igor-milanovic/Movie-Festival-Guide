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
    public class GetLocationsQuery : IGetLocationsQuery
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;

        public GetLocationsQuery(MFGContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Id => 251;

        public string Name => "Locations search";

        public PagedResponse<LocationQueryDto> Execute(LocationSearch search)
        {
            var query = _context.Locations.AsQueryable();

            if (!string.IsNullOrEmpty(search.Name) && !string.IsNullOrWhiteSpace(search.Name))
            {
                query = query.Where(x => x.Name.ToLower().Contains(search.Name.ToLower()));
            }

            if (search.CityID is int)
            {
                query = query.Where(x => x.CityID == search.CityID);
            }

            return query.Paged<LocationQueryDto, Location>(search, _mapper);
        }
    }
}