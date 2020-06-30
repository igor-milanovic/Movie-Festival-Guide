using FluentValidation;
using MFG.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFG.Implementation.Validators
{
    public class BuyTicketReservationValidator : AbstractValidator<int>
    {
        private readonly MFGContext _context;

        public BuyTicketReservationValidator(MFGContext context)
        {
            _context = context;

            RuleFor(x => x)
                .Must(x => _context.TicketReservations.Any(t => t.Id == x))
                .WithMessage("Invalid Reservation ID")
                .DependentRules(() =>
                {
                    RuleFor(x => x)
                        .Must(t =>
                       {
                           return _context.TicketReservations.Find(t).Bought == null;
                       })
                        .WithMessage("Tickets are already picked up!");
                });
        }
    }
}