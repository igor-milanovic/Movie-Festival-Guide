using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.Searches
{
    public class UserSearch : PagedSearch
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public int? RoleID { get; set; }
    }
}