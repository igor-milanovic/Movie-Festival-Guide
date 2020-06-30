using MFG.Application.DataTransfer;
using MFG.Application.Searches;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.Queries
{
    public interface IGetTicketReservationsQuery : IQuery<TicketReservationSearch, PagedResponse<TicketResevationQueryDto>>
    {
    }
}