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
    public class GetHallsQuery : IGetHallsQuery
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;

        public GetHallsQuery(MFGContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Id => 241;

        public string Name => "Halls search";

        public PagedResponse<HallDto> Execute(HallSearch search)
        {
            var query = _context.Halls.AsQueryable();

            if (!string.IsNullOrEmpty(search.Name) && !string.IsNullOrWhiteSpace(search.Name))
            {
                query = query.Where(x => x.Name.ToLower().Contains(search.Name.ToLower()));
            }

            if (search.LocationID is int)
            {
                query = query.Where(x => x.LocationID == search.LocationID);
            }

            if (search.MinSeats is int)
            {
                query = query.Where(x => x.NumberOfSeats > search.MinSeats);
            }

            return query.Paged<HallDto, Hall>(search, _mapper);
        }
    }
}