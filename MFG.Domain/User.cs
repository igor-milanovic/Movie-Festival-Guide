using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Domain
{
    public class User : Entity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public int RoleID { get; set; }

        public virtual ICollection<TicketReservation> TicketReservations { get; set; } = new HashSet<TicketReservation>();
    }
}