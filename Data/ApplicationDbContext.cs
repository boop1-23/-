using HospitalManagement.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Data;

public sealed class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Department> Departments => Set<Department>();
    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<EmploymentContract> EmploymentContracts => Set<EmploymentContract>();
    public DbSet<Patient> Patients => Set<Patient>();
    public DbSet<AuditLog> AuditLogs => Set<AuditLog>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Department>(entity =>
        {
            entity.HasIndex(x => x.Code).IsUnique();
            entity.Property(x => x.Code).HasMaxLength(32);
            entity.Property(x => x.NameAr).HasMaxLength(200);
            entity.Property(x => x.NameEn).HasMaxLength(200);
        });

        builder.Entity<ApplicationUser>()
            .HasOne(x => x.Department)
            .WithMany()
            .HasForeignKey(x => x.DepartmentId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<Employee>(entity =>
        {
            entity.HasIndex(x => x.EmployeeNumber).IsUnique();
            entity.Property(x => x.EmployeeNumber).HasMaxLength(32);
            entity.Property(x => x.FullName).HasMaxLength(200);
            entity.HasOne(x => x.Department)
                .WithMany()
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        builder.Entity<EmploymentContract>(entity =>
        {
            entity.Property(x => x.SalaryAmount).HasPrecision(18, 3);
            entity.Property(x => x.SalaryUnit).HasMaxLength(32);
            entity.HasOne(x => x.Employee)
                .WithMany()
                .HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        builder.Entity<Patient>(entity =>
        {
            entity.HasIndex(x => x.MedicalRecordNumber).IsUnique();
            entity.Property(x => x.MedicalRecordNumber).HasMaxLength(32);
            entity.Property(x => x.FullName).HasMaxLength(200);
            entity.Property(x => x.NationalId).HasMaxLength(32);
        });

        builder.Entity<AuditLog>(entity =>
        {
            entity.Property(x => x.UserId).HasMaxLength(450);
            entity.Property(x => x.UserName).HasMaxLength(256);
            entity.Property(x => x.Action).HasMaxLength(64);
            entity.Property(x => x.Entity).HasMaxLength(64);
            entity.Property(x => x.EntityId).HasMaxLength(64);
            entity.HasIndex(x => x.CreatedAt);
        });
    }
}
