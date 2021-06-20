using System;
using Microsoft.EntityFrameworkCore;
using AttendanceApp.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace AttendanceApp.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Company> Companies { get; set; }
        DbSet<AttendanceRecord> AttendanceRecords { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
