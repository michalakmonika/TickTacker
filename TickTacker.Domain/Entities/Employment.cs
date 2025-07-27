namespace TickTacker.Domain.Entities;

public class Employment
{
    public int Id { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly? EndDate { get; set; }
    public ICollection<DailyAttendance> DailyAttendances { get; set; } = new List<DailyAttendance>();
    public ICollection<PaidVacation> PaidVacations { get; set; } = new List<PaidVacation>();
}
