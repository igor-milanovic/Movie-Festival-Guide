using AutoMapper;
using MFG.Application.DataTransfer;
using MFG.Application.Queries;
using MFG.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Queries
{
    public class GetLocationQuery : IGetLocationQuery
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;

        public GetLocationQuery(MFGContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Id => 252;

        public string Name => "Locations search by id";

        public LocationQueryDto Execute(int search)
        {
            var query = _context.Locations.Find(search);
            return _mapper.Map<LocationQueryDto>(query);
        }
    }
}