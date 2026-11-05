

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using CampusPlacement.Domain.Entities;
using CampusPlacement.Infrastructure.Identity;

namespace CampusPlacement.Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // College and Company
        public DbSet<College> Colleges { get; set; }

        public DbSet<Company> Companies { get; set; }

        // User-related entities
        public DbSet<PlacementOfficer> PlacementOfficers { get; set; }

        public DbSet<CompanyHR> CompanyHRs { get; set; }

        public DbSet<Student> Students { get; set; }

        // Job-related entities
        public DbSet<JobOpening> JobOpenings { get; set; }

        public DbSet<JobTargetCollege> JobTargetColleges { get; set; }

        public DbSet<JobEligibleDepartment> JobEligibleDepartments { get; set; }

        public DbSet<JobEligibleGraduationYear> JobEligibleGraduationYears { get; set; }

        public DbSet<JobApplication> JobApplications { get; set; }

        // Recruitment-related entities
        public DbSet<RecruitmentDrive> RecruitmentDrives { get; set; }

        public DbSet<InterviewRound> InterviewRounds { get; set; }

        public DbSet<InterviewSchedule> InterviewSchedules { get; set; }

        public DbSet<ApplicationStatusHistory> ApplicationStatusHistories { get; set; }

        // Authentication
        public DbSet<RefreshToken> RefreshTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}