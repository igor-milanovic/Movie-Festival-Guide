using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.Searches
{
    public class DirectorSearch : PagedSearch
    {
        //public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}