using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.Searches
{
    public class HallSearch : PagedSearch
    {
        //  public int Id { get; set; }
        public string Name { get; set; }

        public int? LocationID { get; set; }
        public int? MinSeats { get; set; }
    }
}