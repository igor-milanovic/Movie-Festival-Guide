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
    public class GetTicketReservationQuery : IGetTicketReservationsQuery
    {
        private readonly MFGContext _context;
        private readonly IMapper _mapper;

        public GetTicketReservationQuery(MFGContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int Id => 2101;

        public string Name => "Ticket reservation search";

        public PagedResponse<TicketResevationQueryDto> Execute(TicketReservationSearch search)
        {
            var x = _context.Projections.Include(x => x.Movie).Include(x => x.Festival).ThenInclude(x => x.Place).AsQueryable();
            var query = _context.TicketReservations.Include(x => x.Ticket).ThenInclude(x => x.Projection).AsQueryable();
            if (!string.IsNullOrEmpty(search.MovieName) && !string.IsNullOrWhiteSpace(search.MovieName))
            {
                query = query.Where(x => x.Ticket.Projection.Movie.Name.ToLower().Contains(search.MovieName.ToLower()));
            }

            if (!string.IsNullOrEmpty(search.ReservationCode) && !string.IsNullOrWhiteSpace(search.ReservationCode))
            {
                query = query.Where(x => x.ReservationCode == search.ReservationCode);
            }

            if (search.UserID is int)
            {
                query = query.Where(x => x.UserID == search.UserID);
            }

            if (search.TicketID is int)
            {
                query = query.Where(x => x.TicketID == search.TicketID);
            }

            if (search.MovieID is int)
            {
                query = query.Where(x => x.Ticket.Projection.MovieID == search.MovieID);
            }

            if (search.ProjectionId is int)
            {
                query = query.Where(x => x.Ticket.ProjectionID == search.ProjectionId);
            }

            if (search.MinQuantity is int)
            {
                query = query.Where(x => x.Quantity > search.MinQuantity);
            }

            if (search.Bought is bool)
            {
                bool b = (bool)search.Bought;
                if (b)
                {
                    query = query.Where(x => x.Bought != null);
                }
                else
                {
                    query = query.Where(x => x.Bought == null);
                }
            }

            return query.Paged<TicketResevationQueryDto, TicketReservation>(search, _mapper);
        }
    }
}