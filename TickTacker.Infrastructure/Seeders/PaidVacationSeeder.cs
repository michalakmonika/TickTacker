using TickTacker.Domain.Entities;
using TickTacker.Infrastructure.Persistence;
using TickTacker.Infrastructure.Seeders.Interfaces;

namespace TickTacker.Infrastructure.Seeders;

public class PaidVacationSeeder : ISeeder
{
    private readonly TickTackerDbContext _dbContext;

    public PaidVacationSeeder(TickTackerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Seed()
    {
        if (_dbContext.Database.CanConnect() && !_dbContext.PaidVacations.Any())
        {
            var paidVacations = new List<PaidVacation>()
            {
                new PaidVacation()
                {
                    VacationStartDate = new DateOnly(2025, 7, 22),
                    VacationEndDate = new DateOnly(2025, 7, 22),
                    IsApproved = true,
                    EmploymentId = 2
                },
                new PaidVacation()
                {
                    VacationStartDate = new DateOnly(2025, 7, 30),
                    VacationEndDate = new DateOnly(2025, 7, 31),
                    IsApproved = false,
                    EmploymentId = 2
                },
                new PaidVacation()
                {
                    VacationStartDate = new DateOnly(2025, 7, 28),
                    VacationEndDate = new DateOnly(2025, 7, 28),
                    IsApproved = true,
                    EmploymentId = 3
                }
            };

            foreach (PaidVacation paidVacation in paidVacations)
            {
                _dbContext.PaidVacations.Add(paidVacation);
            }

            _dbContext.SaveChanges();
        }            
    }
}
