using FluentValidation;
using MFG.Application.DataTransfer;
using MFG.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFG.Implementation.Validators
{
    public class TicketValidator : AbstractValidator<TicketDto>
    {
        private readonly MFGContext _context;

        public TicketValidator(MFGContext context)
        {
            _context = context;

            RuleFor(x => x.FestivalID)
               .NotNull()
               .WithMessage("FestivalID field is required")
               .Must(p => _context.Festivals.Any(x => x.Id == p))
               .WithMessage("FestivalID not valid!");

            RuleFor(x => x.ProjectionID)
               .NotNull()
               .WithMessage("ProjectionID field is required")
               .Must(p => _context.Projections.Any(x => x.Id == p))
               .WithMessage("ProjectionID not valid!");

            RuleFor(x => x.Price)
                //  .NotNull()     moze not Empty da ne dozvoli 0, ali moze da kosta 0 ako je besplatan ulaz
                // .WithMessage("Price field is required")
                .LessThan(1000000000)
                .WithMessage("Price can have maximum 10 characters");

            RuleFor(x => x)
                .Must(t => !_context.Tickets.Any(x => x.FestivalID == t.FestivalID && x.ProjectionID == t.ProjectionID && x.Id != t.Id))
                .WithMessage("Ticket for that festival and that projection already exists!");
        }
    }
}