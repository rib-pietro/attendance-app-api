using System;
using System.Collections.Generic;
using System.Text;
using AttendanceApp.Domain.Enums;
using AttendanceApp.Domain.Common;

namespace AttendanceApp.Domain.Entities
{
    public class AttendanceRecord : Entity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime Time { get; set; }
        public AttentanceRecordType Type { get; set; }
    }
}
