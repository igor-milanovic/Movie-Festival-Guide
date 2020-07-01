using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.Searches
{
    public class UseCaseLogSearch : PagedSearch
    {
        public int? Id { get; set; }
        public DateTime? BeforeDate { get; set; }
        public DateTime? AfterDate { get; set; }
        public string UseCaseName { get; set; }
        public string Actor { get; set; }
    }
}