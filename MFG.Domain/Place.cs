using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Domain
{
    public class Place : Entity
    {
        public int CityID { get; set; }
        public int LocationID { get; set; }
        public virtual City City { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<Festival> Festivals { get; set; } = new HashSet<Festival>();
    }
}