using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AttendanceApp.Domain.Entities;

namespace AttendanceApp.Infrastructure.Persistence.Configurations
{
    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(e => e.Name)
                .HasMaxLength(200)
                .IsRequired()
                ;

            builder.HasOne(e => e.Company);

            builder.HasMany(e => e.AttendanceRecords);
        }
    }
}
