using Healthcare.Domain.Enums;

namespace Healthcare.Domain.Entities;

public class NurseProfile
{
    public int Id { get; set; }
    public string UserId { get; set; } = string.Empty;

    // Smart Medical CV
    public string Specialty { get; set; } = string.Empty;
    public int YearsOfExperience { get; set; }
    public string? Bio { get; set; }
    public string? Certificates { get; set; } // e.g., JSON list or comma-separated certificates

    // Verification Documents & Admin Review
    public VerificationStatus VerificationStatus { get; set; } = VerificationStatus.Pending;
    public string? PracticeLicenseUrl { get; set; }
    public string? AcademicDegreeUrl { get; set; }
    public string? RejectionReason { get; set; }
    public DateTime? VerifiedAt { get; set; }

    // Home Visit Availability & Location
    public bool IsOnlineForHomeVisits { get; set; }
    public double? CurrentLatitude { get; set; }
    public double? CurrentLongitude { get; set; }

    // Cached Rating Summary
    public double AverageRating { get; set; }
    public int TotalReviews { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation Properties
    public AppUser User { get; set; } = null!;
    public NurseWallet? Wallet { get; set; }
    public ICollection<JobApplication> JobApplications { get; set; } = new List<JobApplication>();
}