using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.DataTransfer
{
    public class TicketCreateDto
    {
        public decimal Price { get; set; }

        public int ProjectionID { get; set; }

        public int FestivalID
        {
            get; set;
        }
    }
}