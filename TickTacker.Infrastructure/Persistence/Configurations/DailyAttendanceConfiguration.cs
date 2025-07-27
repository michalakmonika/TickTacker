using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TickTacker.Domain.Entities;

namespace TickTacker.Infrastructure.Persistence.Configurations;

public class DailyAttendanceConfiguration : IEntityTypeConfiguration<DailyAttendance>
{
    public void Configure(EntityTypeBuilder<DailyAttendance> builder)
    {
        builder.Property(d => d.Date)
            .IsRequired();

        builder.Property(d => d.StartTime)
            .IsRequired();

        builder.Property(d => d.EmploymentId)
            .IsRequired();

        builder.Navigation(d => d.Employment)
            .IsRequired();
    }
}