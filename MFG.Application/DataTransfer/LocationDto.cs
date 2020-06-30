using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.DataTransfer
{
    public class LocationDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CityID { get; set; }

        public virtual ICollection<Hall> Halls { get; set; }
    }
}