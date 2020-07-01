using MFG.Application.DataTransfer;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.Commands.PlaceCommands
{
    public interface ICreatePlaceCommand : ICommand<PlaceCreateDto>
    {
    }
}