using MFG.Application.DataTransfer;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.Commands.LocationCommands
{
    public interface ICreateLocationCommand : ICommand<LocationDto>
    {
    }
}