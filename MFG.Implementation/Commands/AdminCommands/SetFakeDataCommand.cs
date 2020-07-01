using MFG.Application.Commands.AdminCommands;
using MFG.DataAccess;
using MFG.DataAccess.DBHelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFG.Implementation.Commands.AdminCommands
{
    public class SetFakeDataCommand : ISetFakeDataCommand
    {
        private readonly MFGContext _context;

        public SetFakeDataCommand(MFGContext context)
        {
            _context = context;
        }

        public int Id => 1;

        public string Name => "Set fake data";

        public void Execute(int request)
        {
            if (_context.TicketReservations.Count() == 0)
            {
                var _ = new AddFakeData();
                _.GenerateAllFakeData(_context);
            }
        }
    }
}