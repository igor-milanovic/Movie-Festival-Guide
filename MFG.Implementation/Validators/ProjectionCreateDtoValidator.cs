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
    public class ProjectionCreateDtoValidator : AbstractValidator<ProjectionCreateDto>
    {
        private readonly MFGContext _context;

        public ProjectionCreateDtoValidator(MFGContext context)
        {
            _context = context;
            bool fest = false;

            Festival f = new Festival();

            RuleFor(x => x.HallID)
               .NotNull()
               .WithMessage("HallID field is required")
               .Must(p => _context.Halls.Any(x => x.Id == p))
               .WithMessage("HallID not valid!");

            RuleFor(x => x.FestivalID)
              .NotNull()
              .WithMessage("FestivalID field is required")
              .Must(p =>
              {
                  fest = _context.Festivals.Any(x => x.Id == p);
                  if (fest)
                  {
                      f = _context.Festivals.FirstOrDefault(x => x.Id == p);
                  }
                  return fest;
              })
              .WithMessage("FestivalID not valid!");

            RuleFor(x => x.MovieID)
              .NotNull()
              .WithMessage("MovieID field is required")
              .Must(p => _context.Movies.Any(x => x.Id == p))
              .WithMessage("MovieID not valid!");

            if (fest) //ovo mozda ne radi!!!! dobro proveri
            {
                RuleFor(x => x.BeginsAt)
                .InclusiveBetween(f.StartDate, f.EndDate)
                .WithMessage("Projection must be between festival's start and end date!");

                RuleFor(x => x.EndsAt)
                    .GreaterThan(p => p.BeginsAt)
                    .WithMessage("Projection must start before it ends...")
                    .InclusiveBetween(f.StartDate, f.EndDate)
                    .WithMessage("Projection must be between festival's start and end date!");
            }
        }
    }
}