using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceApp.Domain.Entities
{
    class AdminUser : User
    {
        public List<User> SubEmployees
        {
            get
            {
                if (Company == null)
                {
                    throw new NullReferenceException("Company not loaded into AdminUser");
                }
                return Company.CommonEmployees;
            }
            private set { }
        }
    }
}
