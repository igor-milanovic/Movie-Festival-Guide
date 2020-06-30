using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Domain
{
    public class Ticket : Entity
    {
        public decimal Price { get; set; }

        public int ProjectionID { get; set; }

        public int FestivalID { get; set; }

        public virtual Projection Projection { get; set; }

        public virtual Festival Festival { get; set; }

        public virtual ICollection<TicketReservation> TicketReservations { get; set; } = new HashSet<TicketReservation>();
    }
}