using MFG.Application.DataTransfer;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.Commands.MovieCommands
{
    public interface IEditMovieCommand : ICommand<MovieDto>
    {
    }
}