using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.Searches
{
    public class FestivalSearch : PagedSearch
    {
        //  public int Id { get; set; }
        public string Name { get; set; }

        //    public int Year { get; set; }
        //    public int Month { get; set; }
        public int? PlaceID { get; set; }
    }
}