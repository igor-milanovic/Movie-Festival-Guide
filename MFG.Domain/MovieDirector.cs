using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Domain
{
    public class MovieDirector
    {
        public int MovieID { get; set; }
        public int DirectorID { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual Director Director { get; set; }
    }
}