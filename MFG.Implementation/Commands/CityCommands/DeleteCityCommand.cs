using MFG.Application.Commands.CityCommands;
using MFG.Application.Exceptions;
using MFG.DataAccess;
using MFG.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Implementation.Commands.CityCommands
{
    public class DeleteCityCommand : IDeleteCityCommand

    {
        /*
        *  id = xyz
        *  x:  1-command       2-query
        *  y:  class
        *  z:  command num for y-calss
        */

        private readonly MFGContext _context;

        public DeleteCityCommand(MFGContext context)
        {
            _context = context;
        }

        public int Id => 112;

        public string Name => "Delete City";

        public void Execute(int request)
        {
            var city = _context.Cities.Find(request);

            if (city == null)
            {
                throw new EntityNotFoundException(request, typeof(City));
            }

            _context.Cities.Remove(city);

            _context.SaveChanges();
        }
    }
}