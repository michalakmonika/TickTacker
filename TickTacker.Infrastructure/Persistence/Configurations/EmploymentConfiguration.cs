using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TickTacker.Domain.Entities;

namespace TickTacker.Infrastructure.Persistence.Configurations;

public class EmploymentConfiguration : IEntityTypeConfiguration<Employment>
{
    public void Configure(EntityTypeBuilder<Employment> builder)
    {
        builder.Property(e => e.StartDate)
            .IsRequired();
    }
}