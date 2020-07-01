using MFG.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MFG.API.Core
{
    public class UnauthorizedActor : IApplicationActor
    {
        public int Id => 0;

        public string Identity => "Unauthorized user";

        public IEnumerable<int> AllowedUseCases =>
            new int[] { 1, 1111, 1113, 222, 221, 232, 231, 262, 261, 282, 281, 292, 291 };
    }
}