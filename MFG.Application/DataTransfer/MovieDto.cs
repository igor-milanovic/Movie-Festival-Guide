using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.DataTransfer
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Year { get; set; }

        public float AvgRating { get; set; }

        public int Length { get; set; }

        public IEnumerable<int> Directors { get; set; }
    }
}