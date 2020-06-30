using FluentValidation;
using MFG.Application.DataTransfer;
using MFG.DataAccess;
using MFG.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFG.Implementation.Validators
{
    public class TicketReservationValidator : AbstractValidator<TicketReservationDto>
    {
        private readonly MFGContext _context;

        public TicketReservationValidator(MFGContext context)
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
                               _context.TicketReservations.Where(x => x.TicketID == t.Id && x.Id != u.Id).ToList();

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

            /*  RuleFor(x => x.UserID)
                     .NotNull()
                     .WithMessage("UserID field is required")
                     .Must(p => _context.Users.Any(x => x.Id == p))
                     .WithMessage("UserID not valid!");

              RuleFor(x => x)

                  .Must((x) =>
                  {
                      //    var ticket = _context.Tickets.Include(x.)
                      var ticket = _context.Tickets.Find(x.TicketID);
                      var festival = _context.Festivals.Find(ticket.FestivalID);

                      var projection = _context.Projections.FirstOrDefault(x => x.Id == ticket.ProjectionID);
                      var maxNumOfSeats = _context.Halls.Where(x => x.Id == projection.HallID).Select(x => x.NumberOfSeats).FirstOrDefault();
                      var reservationsForProjection =// _context.Tickets.Include(x=> x.TicketReservations).Where(x=>x.ProjectionID==t.ProjectionID).Count()
                        _context.TicketReservations.Where(x => x.TicketID == ticket.Id).ToList();

                      var reservedSeats = 0;

                      foreach (var i in reservationsForProjection)
                      {
                          reservedSeats += i.Quantity;
                      }

                      freeSeats = maxNumOfSeats - reservedSeats;
                      // if (x.Quantity > freeSeats) tmp = false;
                      return x.Quantity > freeSeats;
                  })
                  .WithMessage()*/

            /*

                        bool val = false;
                        Ticket t = new Ticket();
                        Festival f = new Festival();

                        RuleFor(x => x.TicketID)
                           .NotNull()
                           .WithMessage("TicketID field is required")
                           .Must(p =>
                           {
                               val = _context.Tickets.Any(x => x.Id == p);
                               if (val)
                               {
                                   t = _context.Tickets.FirstOrDefault(x => x.Id == p);
                                   f = _context.Festivals.FirstOrDefault(x => x.Id == t.FestivalID);
                               }
                               return val;
                           })
                           .WithMessage("TicketID not valid!");

                        RuleFor(x => x.UserID)
                               .NotNull()
                               .WithMessage("UserID field is required")
                               .Must(p => _context.Users.Any(x => x.Id == p))
                               .WithMessage("UserID not valid!");

                        if (val)
                        {
                            int freeSeats = 99999999; // ako je greska ispisace ovo, provere radi
                            RuleFor(x => x.Quantity)
                              .NotNull()
                              .WithMessage("Quantity field is required")
                              .GreaterThan(0)
                              .WithMessage("Minimum quantity is 1")
                              .LessThan(f.MaxTickets + 1)
                              .WithMessage("Maximum number of tickets per reservation is " + f.MaxTickets)
                              .Must(r =>
                              {
                                  var tmp = true;
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
                                  if (r > freeSeats) tmp = false;
                                  return tmp;
                              })
                              .WithMessage("There is only " + freeSeats + " free seats left");
                        }*/
        }
    }
}