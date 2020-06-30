using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Domain
{
    public class Director : Entity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<MovieDirector> MovieDirectors { get; set; } = new HashSet<MovieDirector>();
    }
}