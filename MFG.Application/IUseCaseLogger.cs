using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application
{
    public interface IUseCaseLogger
    {
        void Log(IUseCase userCase, IApplicationActor actor, object useCaseData);
    }
}