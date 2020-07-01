using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.DataTransfer
{
    public class TicketReservationCreateDto
    {
        public int UserID { get; set; }
        public int TicketID { get; set; }
        public int Quantity { get; set; }
    }
}