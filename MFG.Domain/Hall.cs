using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Domain
{
    public class Hall : Entity
    {
        public string Name { get; set; }

        public int NumberOfSeats { get; set; }

        public int LocationID { get; set; }

        public virtual Location Location { get; set; }

        public ICollection<Projection> Projections { get; set; } = new HashSet<Projection>();
    }
}