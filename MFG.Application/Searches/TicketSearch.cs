using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.Searches
{
    public class TicketSearch : PagedSearch
    {
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }

        public int? ProjectionID { get; set; }

        public int? FestivalID { get; set; }
    }
}