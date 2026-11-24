namespace HospitalManagement.Models;

public enum ContractType
{
    Permanent = 1,
    FixedTerm = 2,
    Daily = 3,
    Hourly = 4
}

public sealed class EmploymentContract
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public Guid EmployeeId { get; set; }
    public Employee? Employee { get; set; }
    public ContractType Type { get; set; } = ContractType.Permanent;
    public DateOnly StartDate { get; set; }
    public DateOnly? EndDate { get; set; }
    public decimal SalaryAmount { get; set; }
    public string SalaryUnit { get; set; } = "شهري";
    public bool IsActive { get; set; } = true;
    public DateTimeOffset CreatedAt { get; private set; } = DateTimeOffset.UtcNow;
}
