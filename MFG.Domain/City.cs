using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MFG.Domain
{
    public class City : Entity
    {
        public string Name { get; set; }

        //[JsonIgnore]
        public virtual ICollection<Location> Locations { get; set; } = new HashSet<Location>();
    }
}