using TickTacker.Domain.Entities;

namespace TickTacker.Domain.Interfaces;

public interface IEmployeeRepository
{
    void Create(Employee employee);
}
