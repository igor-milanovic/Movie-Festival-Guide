using FluentValidation;
using MFG.Application.DataTransfer;
using MFG.DataAccess;
using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFG.Implementation.Validators
{
    public class TicketReservationCreateDtoValidator : AbstractValidator<TicketReservationCreateDto>
    {
        private readonly MFGContext _context;

        public TicketReservationCreateDtoValidator(MFGContext context)
        {
            _context = context;

            bool val = false;
            Ticket t = new Ticket();
            Festival f = new Festival();
            int freeSeats = 99999999; // ako je greska ispisace ovo, provere radi
            int maxTickets = 888888888; //ako je greska ispisace ovo

            RuleFor(x => x.TicketID)
               .NotNull()
               .WithMessage("TicketID field is required")
               .Must((u, p) =>
               {
                   val = _context.Tickets.Any(x => x.Id == u.TicketID);
                   if (val)
                   {
                       /*  t = _context.Tickets.Find(u.TicketID);
                         f = _context.Festivals.Find(t.FestivalID);
                         maxTickets = f.MaxTickets;*/
                   }
                   return val;
               })
               .WithMessage("TicketID not valid!")
               .DependentRules(() =>
               {
                   RuleFor(x => x.Quantity)
                     .NotEmpty()
                     .WithMessage("Quantity field is required")
                     .GreaterThan(0)
                     .WithMessage("Minimum quantity is 1")
                     .Must((x, y) =>
                     {
                         t = _context.Tickets.Find(x.TicketID);
                         f = _context.Festivals.Find(t.FestivalID);
                         maxTickets = f.MaxTickets;
                         return y <= maxTickets;
                     })
                     .WithMessage("Maximum number of tickets exceeded")
                     .DependentRules(() =>
                     {
                         RuleFor(x => x.Quantity)
                         .Must((u, r) =>
                         {
                             var tmp = true;
                             t = _context.Tickets.Find(u.TicketID);
                             f = _context.Festivals.Find(t.FestivalID);
                             var projection = _context.Projections.FirstOrDefault(x => x.Id == t.ProjectionID);
                             var maxNumOfSeats = _context.Halls.Where(x => x.Id == projection.HallID).Select(x => x.NumberOfSeats).FirstOrDefault();
                             var reservationsForProjection =// _context.Tickets.Include(x=> x.TicketReservations).Where(x=>x.ProjectionID==t.ProjectionID).Count()
                               _context.TicketReservations.Where(x => x.TicketID == t.Id).ToList();

                             var reservedSeats = 0;

                             foreach (var i in reservationsForProjection)
                             {
                                 reservedSeats += i.Quantity;
                             }

                             freeSeats = maxNumOfSeats - reservedSeats;
                             if (u.Quantity > freeSeats) tmp = false;
                             return tmp;
                         })
                     // .WithMessage("There is only " + freeSeats + " free seats left");
                     .WithMessage("There is fewer free seats left than you requested");
                     });
               });
        }
    }
}