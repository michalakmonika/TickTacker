using TickTacker.Domain.Entities;
using TickTacker.Infrastructure.Persistence;
using TickTacker.Infrastructure.Seeders.Interfaces;

namespace TickTacker.Infrastructure.Seeders;

public class EmploymentSeeder : ISeeder
{
    private readonly TickTackerDbContext _dbContext;

    public EmploymentSeeder(TickTackerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Seed()
    {
        if (_dbContext.Database.CanConnect() && !_dbContext.Employments.Any())
        {
            var employments = new List<Employment>()
            {
                new Employment()
                {
                    StartDate = new DateOnly(2020, 5, 10)
                },
                new Employment()
                {
                    StartDate = new DateOnly(2025, 1, 2)
                },
                new Employment()
                {
                    StartDate = new DateOnly(2025, 4, 21)
                }
            };

            foreach (Employment employment in employments)
            {
                _dbContext.Employments.Add(employment);
            }

            _dbContext.SaveChanges();
        }           
    }
}
