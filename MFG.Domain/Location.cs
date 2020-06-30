using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Domain
{
    public class Location : Entity
    {
        public string Name { get; set; }

        public virtual ICollection<Hall> Halls { get; set; } = new HashSet<Hall>();

        public int CityID { get; set; }
        public virtual City City { get; set; }
    }
}