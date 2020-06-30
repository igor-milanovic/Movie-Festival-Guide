using FluentValidation;
using MFG.Application.DataTransfer;
using MFG.DataAccess;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFG.Implementation.Validators
{
    public class PickTicketReservationValidator : AbstractValidator<PickTicketReservationDto>
    {
        private readonly MFGContext _context;

        public PickTicketReservationValidator(MFGContext context)
        {
            _context = context;

            RuleFor(x => x.ReservationCode)
                .Must(x => _context.TicketReservations.Any(t => t.ReservationCode == x))
                .WithMessage("Invalid reservation code");
        }
    }
}