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
    public class GetTicketsQuery : IGetTicketsQuery
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;

        public GetTicketsQuery(MFGContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Id => 291;

        public string Name => "Tickets search";

        public PagedResponse<TicketDto> Execute(TicketSearch search)
        {
            var query = _context.Tickets.AsQueryable();

            if (search.ProjectionID is int)
            {
                query = query.Where(x => x.ProjectionID == search.ProjectionID);
            }

            if (search.FestivalID is int)
            {
                query = query.Where(x => x.FestivalID == search.FestivalID);
            }

            if (search.MinPrice is decimal)
            {
                query = query.Where(x => x.Price >= search.MinPrice);
            }

            if (search.MaxPrice is decimal)
            {
                query = query.Where(x => x.Price <= search.MaxPrice);
            }

            return query.Paged<TicketDto, Ticket>(search, _mapper);
        }
    }
}