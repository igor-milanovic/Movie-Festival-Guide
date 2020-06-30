using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.Searches
{
    public class ProjectionSearch : PagedSearch
    {
        public int Id { get; set; }
        public int? MovieID { get; set; }

        public string MovieName { get; set; }
        public int? HallID { get; set; }
        public int? FestivalID { get; set; }
        public int? LocationID { get; set; }
    }
}