using CampusPlacement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CampusPlacement.Application.Interfaces.Data;

/// <summary>
/// Abstraction for the application database context exposing domain entity sets.
/// </summary>
public interface IApplicationDbContext
{
    DbSet<College> Colleges { get; }
    DbSet<Company> Companies { get; }
    DbSet<PlacementOfficer> PlacementOfficers { get; }
    DbSet<CompanyHR> CompanyHRs { get; }
    DbSet<Student> Students { get; }
    DbSet<JobOpening> JobOpenings { get; }
    DbSet<JobTargetCollege> JobTargetColleges { get; }
    DbSet<JobEligibleDepartment> JobEligibleDepartments { get; }
    DbSet<JobEligibleGraduationYear> JobEligibleGraduationYears { get; }
    DbSet<JobApplication> JobApplications { get; }
    DbSet<RecruitmentDrive> RecruitmentDrives { get; }
    DbSet<InterviewRound> InterviewRounds { get; }
    DbSet<InterviewSchedule> InterviewSchedules { get; }
    DbSet<ApplicationStatusHistory> ApplicationStatusHistories { get; }
    DbSet<RefreshToken> RefreshTokens { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
