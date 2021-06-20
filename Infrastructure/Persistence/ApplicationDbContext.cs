using System;
using System.Collections.Generic;
using System.Text;
using AttendanceApp.Domain.Entities;
using AttendanceApp.Application.Common.Interfaces;
using AttendanceApp.Infrastructure.Services.DateTime;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace AttendanceApp.Infrastructure.Persistence
{
    class ApplicationDbContext : IApplicationDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<AttendanceRecord> AttendanceRecords { get; set; }

        private readonly IDateTimeService _dateTimeService;

        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions,
        )
        //public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
