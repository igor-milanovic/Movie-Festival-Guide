using AutoMapper;
using MFG.Application.DataTransfer;
using MFG.Application.Queries;
using MFG.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Queries
{
    public class GetHallQuery : IGetHallQuery
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;

        public GetHallQuery(MFGContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Id => 242;

        public string Name => "Halls search by id";

        public HallDto Execute(int search)
        {
            var query = _context.Halls.Find(search);

            return _mapper.Map<HallDto>(query);
        }
    }
}