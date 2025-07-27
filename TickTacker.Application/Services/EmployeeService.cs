using TickTacker.Application.Services.Interfaces;
using TickTacker.Domain.Entities;
using TickTacker.Domain.Interfaces;

namespace TickTacker.Application.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public void Create(Employee employee)
    {
        _employeeRepository.Create(employee);
    }
}
