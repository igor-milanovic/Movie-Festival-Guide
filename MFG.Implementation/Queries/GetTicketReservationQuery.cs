using AutoMapper;
using MFG.Application.DataTransfer;
using MFG.Application.Queries;
using MFG.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Queries
{
    public class GetTicketReservationQuery : IGetTicketReservationQuery
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;

        public GetTicketReservationQuery(MFGContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Id => 2102;

        public string Name => "Ticket reservation search by id";

        public TicketResevationQueryDto Execute(int search)
        {
            var _ = _context.TicketReservations.Find(search);
            return _mapper.Map<TicketResevationQueryDto>(_);
        }
    }
}