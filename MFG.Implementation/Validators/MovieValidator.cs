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
    public class MovieValidator : AbstractValidator<MovieDto>
    {
        private readonly MFGContext _context;

        public MovieValidator(MFGContext context)
        {
            _context = context;

            RuleFor(x => x.Name)
               .NotEmpty()
               .WithMessage("Name field is required")
               .MinimumLength(3)
               .WithMessage("Name field must have at least 3 characters")
               .MaximumLength(30)
               .WithMessage("Name field can have maximum 30 characters");

            RuleFor(x => x.Length)
                 .NotEmpty()
                 .WithMessage("Length field is required")
                 .InclusiveBetween(10, 500)
                 .WithMessage("Movie must last between 10 and 500 minutes");

            RuleFor(x => x.AvgRating)
                .NotEmpty()
                 .WithMessage("AvgRating field is required")
                 .InclusiveBetween(1, 5)
                 .WithMessage("AvgRating must be between 1 and 5");

            RuleFor(x => x.Year)
                .NotEmpty()
                .WithMessage("Year field is required")
                .InclusiveBetween(1900, DateTime.Now.Year)
                .WithMessage("Year must be  between 1900 and current year");

            RuleFor(x => x.Directors)
                .NotEmpty()
                .WithMessage("You must select at least 1 director")
                //  .Must(x=> _context.MovieDirector.Where(x=> x.DirectorID ==))   -> DISTINCT !!!! ne moze isti reziser da rezira isti film nekoli puta
                .DependentRules(() =>
                {
                    RuleForEach(x => x.Directors)
                        .NotNull()
                        .WithMessage("You must select at least 1 director")
                        .Must(i => _context.Directors.Any(x => x.Id == i))
                        .WithMessage("Director ID not valid");
                });
        }
    }
}