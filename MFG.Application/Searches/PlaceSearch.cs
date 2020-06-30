using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.Searches
{
    public class PlaceSearch : PagedSearch
    {
        public int Id { get; set; }
        public int? CityID { get; set; }
        public int? LocationID { get; set; }
    }
}