using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MFG.Domain
{
    public class Movie : Entity
    {
        public string Name { get; set; }

        public int Year { get; set; }

        public float AvgRating { get; set; }

        public int Length { get; set; }

        [JsonIgnore]
        public virtual ICollection<Projection> Projections { get; set; } = new HashSet<Projection>();

        public virtual ICollection<MovieDirector> MovieDirectors { get; set; } = new HashSet<MovieDirector>();
    }
}