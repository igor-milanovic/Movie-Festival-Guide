using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.DataTransfer
{
    public class MovieCreateDto
    {
        public string Name { get; set; }

        public int Year { get; set; }

        public float AvgRating { get; set; }

        public int Length { get; set; }

        public IEnumerable<int> Directors { get; set; }
    }
}