using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Domain
{
    public class RoleUseCase
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int UseCaseId { get; set; }
    }
}