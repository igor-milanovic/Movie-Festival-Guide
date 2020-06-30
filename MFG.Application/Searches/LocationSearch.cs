using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.Searches
{
    public class LocationSearch : PagedSearch
    {
        public string Name { get; set; }

        public int? CityID { get; set; }
    }
}