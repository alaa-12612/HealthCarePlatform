using Healthcare.Domain.Entities;
using Healthcare.Domain.Enums;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Healthcare.Infrastructure.Persistence;

public class AppDbContext : IdentityDbContext<AppUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<PatientProfile> PatientProfiles => Set<PatientProfile>();
    public DbSet<NurseProfile> NurseProfiles => Set<NurseProfile>();
    public DbSet<HealthcareFacilityProfile> HealthcareFacilityProfiles => Set<HealthcareFacilityProfile>();
    public DbSet<NursingService> NursingServices => Set<NursingService>();
    public DbSet<HomeVisitRequest> HomeVisitRequests => Set<HomeVisitRequest>();
    public DbSet<RequestServiceItem> RequestServiceItems => Set<RequestServiceItem>();
    public DbSet<PatientVitalLog> PatientVitalLogs => Set<PatientVitalLog>();
    public DbSet<JobPosting> JobPostings => Set<JobPosting>();
    public DbSet<JobApplication> JobApplications => Set<JobApplication>();
    public DbSet<NurseWallet> NurseWallets => Set<NurseWallet>();
    public DbSet<WalletTransaction> WalletTransactions => Set<WalletTransaction>();
    public DbSet<Review> Reviews => Set<Review>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<AppUser>(entity =>
        {
            entity.Property(u => u.Role)
                .HasConversion<string>()
                .HasMaxLength(30);

            entity.Property(u => u.IsActive)
                .HasDefaultValue(true);

            entity.HasOne(u => u.PatientProfile)
                .WithOne(p => p.User)
                .HasForeignKey<PatientProfile>(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(u => u.NurseProfile)
                .WithOne(n => n.User)
                .HasForeignKey<NurseProfile>(n => n.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(u => u.FacilityProfile)
                .WithOne(f => f.User)
                .HasForeignKey<HealthcareFacilityProfile>(f => f.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}