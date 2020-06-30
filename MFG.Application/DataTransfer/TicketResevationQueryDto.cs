using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.DataTransfer
{
    public class TicketResevationQueryDto
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int TicketID { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime? Bought { get; set; }
        public string ReservationCode { get; set; }
    }
}