using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.DataTransfer
{
    public class TicketReservationDto
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int TicketID { get; set; }
        public int Quantity { get; set; }
        //public decimal TotalPrice { get; set; }    //ja racunam!!

        //public DateTime ReservationDate { get; set; }  //user ne vidi i ne unosi se s polja
        //public DateTime? Bought { get; set; }  //user ne vidi i ne unosi se s polja
        //public string ReservationCode { get; set; }  //user ne vidi i ne unosi se s polja
    }
}