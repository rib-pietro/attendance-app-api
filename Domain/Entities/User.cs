using System.Collections.Generic;
using AttendanceApp.Domain.Enums;
using AttendanceApp.Domain.Common;

namespace AttendanceApp.Domain.Entities
{
    public class User : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public List<AttendanceRecord> AttendanceRecords { get; set; } = new List<AttendanceRecord>();
    }
}
