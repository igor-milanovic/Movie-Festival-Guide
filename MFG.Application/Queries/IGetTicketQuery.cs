using MFG.Application.DataTransfer;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.Queries
{
    public interface IGetTicketQuery : IQuery<int, TicketDto>
    {
    }
}