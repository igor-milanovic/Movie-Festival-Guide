using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.DataTransfer
{
    public class MovieQueryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Year { get; set; }

        public float AvgRating { get; set; }

        public int Length { get; set; }
    }
}