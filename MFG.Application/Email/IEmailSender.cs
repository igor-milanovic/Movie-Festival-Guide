using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.Email
{
    public interface IEmailSender
    {
        void Send(SendEmailDto dto);
    }
}