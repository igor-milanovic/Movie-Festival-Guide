using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.DataTransfer
{
    public class FestivalDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string About { get; set; }
        public int MaxTickets { get; set; }
        public int PlaceID { get; set; }
        public virtual IEnumerable<int> Projections { get; set; }
        public virtual IEnumerable<int> Tickets { get; set; }
    }
}