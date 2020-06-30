using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.DataTransfer
{
    public class CityQueryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // public ICollection<Location> Locations { get; set; } = new HashSet<Location>();
    }
}