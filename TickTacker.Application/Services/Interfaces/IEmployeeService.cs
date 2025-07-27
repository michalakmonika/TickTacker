using TickTacker.Domain.Entities;

namespace TickTacker.Application.Services.Interfaces;

public interface IEmployeeService
{
    void Create(Employee employee);
}
