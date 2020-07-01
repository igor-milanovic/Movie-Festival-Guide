using AutoMapper;
using MFG.Application.DataTransfer;
using MFG.Application.Queries;
using MFG.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Queries
{
    public class GetPlaceQuery : IGetPlaceQuery
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;

        public GetPlaceQuery(MFGContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Id => 272;

        public string Name => "Places search by id";

        public PlaceDto Execute(int search)
        {
            var query = _context.Places.Find(search);

            return _mapper.Map<PlaceDto>(query);
        }
    }
}