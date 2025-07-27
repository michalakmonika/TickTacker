namespace TickTacker.Domain.Entities;

public class PaidVacation
{
    public int Id { get; set; }
    public DateOnly VacationStartDate { get; set; }
    public DateOnly VacationEndDate { get; set; }
    public bool IsApproved { get; set; }
    public int EmploymentId { get; set; }
    public Employment Employment { get; set; } = default!;
}
