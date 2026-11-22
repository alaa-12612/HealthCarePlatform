using Healthcare.Domain.Enums;

namespace Healthcare.Domain.Entities;

public class JobApplication
{
    public int Id { get; set; }

    // Foreign Keys
    public int JobPostingId { get; set; }
    public string NurseId { get; set; } = string.Empty;

    // Application Details & ATS Pipeline
    public ApplicationStatus Status { get; set; } = ApplicationStatus.UnderReview;
    public string? CoverNote { get; set; }
    public string? FacilityNotes { get; set; }

    // Timestamps
    public DateTime AppliedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }

    // Navigation Properties
    public JobPosting JobPosting { get; set; } = null!;
    public AppUser Nurse { get; set; } = null!;
}