using System;
using System.Collections.Generic;
using System.Text;
using AttendanceApp.Domain.Common;
using AttendanceApp.Domain.Enums;

namespace AttendanceApp.Domain.Entities
{
    public class Company : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public List<User> Employees { get; set; } = new List<User>();

        public List<User> AdminEmployees
        {
            get
            {
                return FilterEmployees(Role.Admin);
            }
            private set { }
        }

        public List<User> CommonEmployees
        {
            get
            {
                return FilterEmployees(Role.Employee);
            }
            private set { }
        }

        private List<User> FilterEmployees(Role role)
        {
            return Employees.FindAll(e => e.Role == role);
        }
    }
}
