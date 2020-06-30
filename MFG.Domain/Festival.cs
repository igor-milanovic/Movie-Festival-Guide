using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Domain
{
    public class Festival : Entity
    {
        public string Name { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string About { get; set; }
        public int MaxTickets { get; set; }
        public int PlaceID { get; set; }
        public virtual Place Place { get; set; }

        public virtual ICollection<Projection> Projections { get; set; } = new HashSet<Projection>();
        public virtual ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();
    }
}