using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TickTacker.Domain.Entities;

namespace TickTacker.Infrastructure.Persistence.Configurations;

public class PaidVacationConfiguration : IEntityTypeConfiguration<PaidVacation>
{
    public void Configure(EntityTypeBuilder<PaidVacation> builder)
    {
        builder.Property(p => p.VacationStartDate)
            .IsRequired();

        builder.Property(p => p.VacationEndDate)
            .IsRequired();

        builder.Property(p => p.EmploymentId)
            .IsRequired();

        builder.Navigation(p => p.Employment)
            .IsRequired();
    }
}