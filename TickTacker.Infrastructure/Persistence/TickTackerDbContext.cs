using Microsoft.EntityFrameworkCore;
using TickTacker.Domain.Entities;

namespace TickTacker.Infrastructure.Persistence;

public class TickTackerDbContext : DbContext
{
    public TickTackerDbContext(DbContextOptions<TickTackerDbContext> options) : base(options)
    {
        
    }

    public DbSet<DailyAttendance> DailyAttendances { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Employment> Employments { get; set; }
    public DbSet<PaidVacation> PaidVacations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TickTackerDbContext).Assembly);
    }
}
