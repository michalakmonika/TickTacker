using TickTacker.Domain.Entities;
using TickTacker.Domain.Interfaces;
using TickTacker.Infrastructure.Persistence;

namespace TickTacker.Infrastructure.Repositories;

internal class EmployeeRepository : IEmployeeRepository
{
    private readonly TickTackerDbContext _dbContext;

    public EmployeeRepository(TickTackerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Create(Employee employee)
    {
        _dbContext.Add(employee);
        _dbContext.SaveChanges();
    }
}
