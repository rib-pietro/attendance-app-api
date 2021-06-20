using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using AttendanceApp.Domain.Entities;

namespace AttendanceApp.Infrastructure.Persistence.Configurations
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.Property(e => e.Name)
                .HasMaxLength(200)
                .IsRequired()
                ;

            builder.OwnsMany(b => b.Employees);
        }
    }
}
