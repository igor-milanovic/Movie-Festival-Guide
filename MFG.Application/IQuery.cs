using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application
{
    public interface IQuery<TSearch, TResult> : IUseCase
    {
        TResult Execute(TSearch search);
    }
}