using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TickTacker.Domain.Interfaces;
using TickTacker.Infrastructure.Persistence;
using TickTacker.Infrastructure.Repositories;
using TickTacker.Infrastructure.Seeders;
using TickTacker.Infrastructure.Seeders.Interfaces;

namespace TickTacker.Infrastructure.Extensions;

public static class InfrastructureServiceExtension
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<TickTackerDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("TickTacker")));

        services.AddScoped<ISeeder, EmploymentSeeder>();
        services.AddScoped<ISeeder, DailyAttendanceSeeder>();
        services.AddScoped<ISeeder, EmployeeSeeder>();
        services.AddScoped<ISeeder, PaidVacationSeeder>();
        services.AddScoped<DataSeeder>();

        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
    }
}
