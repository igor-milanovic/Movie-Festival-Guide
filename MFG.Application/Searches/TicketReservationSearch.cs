using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.Searches
{
    public class TicketReservationSearch : PagedSearch
    {
        //   public int Id { get; set; }
        public int? UserID { get; set; }

        public int? TicketID { get; set; }
        public int? MinQuantity { get; set; }
        public bool? Bought { get; set; }
        public string ReservationCode { get; set; }
        public string MovieName { get; set; }
        public int? MovieID { get; set; }
        public int? ProjectionId { get; set; }
    }
}