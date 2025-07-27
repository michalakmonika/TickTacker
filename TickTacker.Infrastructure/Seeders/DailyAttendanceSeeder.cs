using TickTacker.Domain.Entities;
using TickTacker.Infrastructure.Persistence;
using TickTacker.Infrastructure.Seeders.Interfaces;

namespace TickTacker.Infrastructure.Seeders;

public class DailyAttendanceSeeder : ISeeder
{
    private readonly TickTackerDbContext _dbContext;

    public DailyAttendanceSeeder(TickTackerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Seed()
    {
        if (_dbContext.Database.CanConnect() && !_dbContext.DailyAttendances.Any())
        {
            var dailyAttendances = new List<DailyAttendance>()
            {
                new DailyAttendance()
                {
                    Date = new DateOnly(2025, 7, 22),
                    StartTime = new TimeOnly(7, 46),
                    EndTime = new TimeOnly(16, 3),
                    EmploymentId = 1
                },
                new DailyAttendance()
                {
                    Date = new DateOnly(2025, 7, 22),
                    StartTime = new TimeOnly(7, 52),
                    EndTime = new TimeOnly(16, 2),
                    EmploymentId = 3
                },
                new DailyAttendance()
                {
                    Date = new DateOnly(2025, 7, 23),
                    StartTime = new TimeOnly(7, 59),
                    EndTime = new TimeOnly(16, 1),
                    EmploymentId = 1
                },
                new DailyAttendance()
                {
                    Date = new DateOnly(2025, 7, 23),
                    StartTime = new TimeOnly(8, 2),
                    EndTime = new TimeOnly(16, 3),
                    EmploymentId = 2
                },
                new DailyAttendance()
                {
                    Date = new DateOnly(2025, 7, 23),
                    StartTime = new TimeOnly(7, 32),
                    EndTime = new TimeOnly(16, 12),
                    EmploymentId = 3
                },
                new DailyAttendance()
                {
                    Date = new DateOnly(2025, 7, 24),
                    StartTime = new TimeOnly(7, 57),
                    EndTime = new TimeOnly(16, 5),
                    EmploymentId = 1
                },
                new DailyAttendance()
                {
                    Date = new DateOnly(2025, 7, 24),
                    StartTime = new TimeOnly(7, 40),
                    EndTime = new TimeOnly(16, 19),
                    EmploymentId = 2
                },
                new DailyAttendance()
                {
                    Date = new DateOnly(2025, 7, 24),
                    StartTime = new TimeOnly(7, 48),
                    EndTime = new TimeOnly(16, 0),
                    EmploymentId = 3
                }
            };

            foreach(DailyAttendance dailyAttendance in dailyAttendances)
            {
                _dbContext.DailyAttendances.Add(dailyAttendance);
            }

            _dbContext.SaveChanges();
        }       
    }   
}