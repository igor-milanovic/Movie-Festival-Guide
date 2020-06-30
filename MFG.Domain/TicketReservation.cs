using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Domain
{
    public class TicketReservation : Entity
    {
        public int UserID { get; set; }
        public int TicketID { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime? Bought { get; set; }
        public string ReservationCode { get; set; }
        public virtual User User { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}