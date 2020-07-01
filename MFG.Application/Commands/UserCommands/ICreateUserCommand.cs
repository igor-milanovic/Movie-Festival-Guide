using MFG.Application.DataTransfer;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.Commands.UserCommands
{
    public interface ICreateUserCommand : ICommand<UserCreateDto>
    {
    }
}