using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.Email
{
    public class SendEmailDto
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public string SendTo { get; set; }
    }
}