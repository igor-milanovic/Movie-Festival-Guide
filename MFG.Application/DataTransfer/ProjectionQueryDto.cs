using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.DataTransfer
{
    public class ProjectionQueryDto
    {
        public int Id { get; set; }
        public DateTime BeginsAt { get; set; }
        public DateTime EndsAt { get; set; }
        public Movie Movie { get; set; }
        public int HallID { get; set; }
        public int FestivalID { get; set; }
    }
}