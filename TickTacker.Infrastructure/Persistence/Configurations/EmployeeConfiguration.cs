using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TickTacker.Domain.Entities;

namespace TickTacker.Infrastructure.Persistence.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.Property(e => e.FirstName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(e => e.MiddleName)
            .HasMaxLength(50);

        builder.Property(e => e.LastName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(e => e.Pesel)
            .IsRequired()
            .HasMaxLength(11)
            .HasColumnType("char(11)");

        builder.HasIndex(e => e.Pesel)
            .IsUnique();

        builder.Property(e => e.BirthDate)
            .IsRequired();

        builder.OwnsOne(e => e.EmergencyContact, contact =>
        {
            contact.Property(c => c.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            contact.Property(c => c.LastName)
                .IsRequired()
                .HasMaxLength(50);

            contact.Property(c => c.PhoneNumber)
                .IsRequired()
                .HasMaxLength(20);
        });

        builder.OwnsOne(e => e.Address, address =>
        {
            address.Property(a => a.Country)
                .IsRequired()
                .HasMaxLength(30);

            address.Property(a => a.City)
                .IsRequired()
                .HasMaxLength(30);

            address.Property(a => a.Street)
                .IsRequired()
                .HasMaxLength(30);

            address.Property(a => a.HouseNumber)
                .IsRequired()
                .HasMaxLength(10);

            address.Property(a => a.ApartmentNumber)
                .HasMaxLength(10);

            address.Property(a => a.PostalCode)
                .IsRequired()
                .HasMaxLength(10);

            address.Property(a => a.HouseNumber)
                .IsRequired()
                .HasMaxLength(20);
        });
    }
}