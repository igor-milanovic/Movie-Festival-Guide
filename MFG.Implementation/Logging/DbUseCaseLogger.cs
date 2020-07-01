﻿using MFG.Application;
using MFG.DataAccess;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Logging
{
    public class DbUseCaseLogger : IUseCaseLogger
    {
        private readonly MFGContext _context;

        public DbUseCaseLogger(MFGContext context)
        {
            _context = context;
        }

        public void Log(IUseCase useCase, IApplicationActor actor, object useCaseData)
        {
            _context.UseCaseLogs.Add(new Domain.UseCaseLog
            {
                Actor = actor.Identity,
                Data = JsonConvert.SerializeObject(useCaseData),
                Date = DateTime.UtcNow,
                UseCaseName = useCase.Name
            });

            _context.SaveChanges();
        }
    }
}