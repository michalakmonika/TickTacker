namespace TickTacker.Domain.Entities;

public class DailyAttendance
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly? EndTime { get; set; }
    public int EmploymentId { get; set; }
    public Employment Employment { get; set; } = default!;
}
