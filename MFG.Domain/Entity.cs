using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Domain
{
    public class Entity
    {
        public int Id { get; set; }

        public DateTime? ModifiedAt { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsActive { get; set; }

        public DateTime? DeletedAt { get; set; }
    }
}