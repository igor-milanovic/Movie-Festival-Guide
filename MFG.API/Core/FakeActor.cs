using MFG.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MFG.API.Core
{
    public class FakeActor : IApplicationActor
    {
        public int Id => 0;

        public string Identity => "Test user";

        public IEnumerable<int> AllowedUseCases => Enumerable.Range(0, 3000);
    }
}