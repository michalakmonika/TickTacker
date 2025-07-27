using Microsoft.Extensions.DependencyInjection;
using TickTacker.Application.Services;
using TickTacker.Application.Services.Interfaces;

namespace TickTacker.Application.Extensions;

public static class ApplicationServiceExtenstion
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IEmployeeService, EmployeeService>();
    }
}
