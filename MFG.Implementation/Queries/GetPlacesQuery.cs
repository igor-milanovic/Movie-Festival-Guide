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
    public class GetPlacesQuery : IGetPlacesQuery
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;

        public GetPlacesQuery(MFGContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Id => 271;

        public string Name => "Places search";

        public PagedResponse<PlaceDto> Execute(PlaceSearch search)
        {
            var query = _context.Places.AsQueryable();

            if (search.LocationID is int)
            {
                query = query.Where(x => x.LocationID == search.LocationID);
            }

            if (search.CityID is int)
            {
                query = query.Where(x => x.CityID == search.CityID);
            }

            return query.Paged<PlaceDto, Place>(search, _mapper);
        }
    }
}