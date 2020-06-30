using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.Searches
{
    public class MovieSearch : PagedSearch
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? Year { get; set; }

        public float? RatingAbove { get; set; }
    }
}