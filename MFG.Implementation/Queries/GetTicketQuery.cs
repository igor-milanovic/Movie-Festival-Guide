using AutoMapper;
using MFG.Application.DataTransfer;
using MFG.Application.Queries;
using MFG.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Queries
{
    public class GetTicketQuery : IGetTicketQuery
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;

        public GetTicketQuery(MFGContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Id => 292;

        public string Name => "Tickets search by ID";

        public TicketDto Execute(int search)
        {
            var ticket = _context.Tickets.Find(search);
            return _mapper.Map<TicketDto>(ticket);
        }
    }
}