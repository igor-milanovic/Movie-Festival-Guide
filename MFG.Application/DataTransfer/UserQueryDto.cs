using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.DataTransfer
{
    public class UserQueryDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public int RoleID { get; set; }
    }
}