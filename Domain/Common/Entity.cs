using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceApp.Domain.Common
{
    public abstract class Entity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Active { get; set; }
    }
}
