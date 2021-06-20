using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceApp.Infrastructure.Services.DateTime
{
    public abstract class IDateTimeService
    {
        public abstract System.DateTime Now();
    }
}
