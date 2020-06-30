using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Domain
{
    public class Projection : Entity
    {
        public DateTime BeginsAt { get; set; }
        public DateTime EndsAt { get; set; }
        public int MovieID { get; set; }
        public int HallID { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual Hall Hall { get; set; }

        public int FestivalID { get; set; }
        public virtual Festival Festival { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();
    }
}