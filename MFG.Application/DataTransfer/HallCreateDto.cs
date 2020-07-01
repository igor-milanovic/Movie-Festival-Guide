using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.DataTransfer
{
    public class HallCreateDto
    {
        public string Name { get; set; }
        public int LocationID { get; set; }
        public int NumberOfSeats { get; set; }
    }
}