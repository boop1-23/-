namespace HospitalManagement.Models;

public sealed class Department
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Code { get; set; } = string.Empty;
    public string NameAr { get; set; } = string.Empty;
    public string NameEn { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
    public DateTimeOffset CreatedAt { get; private set; } = DateTimeOffset.UtcNow;
}
