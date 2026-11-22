using Healthcare.Domain.Enums;

namespace Healthcare.Domain.Entities;

public class JobPosting
{
    public int Id { get; set; }

    // Foreign Key
    public int FacilityProfileId { get; set; }

    // Job / Shift Details
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public JobType JobType { get; set; }
    public bool IsUrgentShift { get; set; }

    // Requirements & Compensation
    public string RequiredSpecialty { get; set; } = string.Empty;
    public int MinYearsOfExperience { get; set; }
    public decimal? CompensationAmount { get; set; }
    public string? CompensationUnit { get; set; } // e.g., "Per Month", "Per Shift", "Per Task"

    // Location & Schedule
    public string? Location { get; set; }
    public DateTime? ShiftStartTime { get; set; }
    public DateTime? ShiftEndTime { get; set; }

    // Status & Moderation
    public bool IsOpen { get; set; } = true;
    public bool IsRemovedByAdmin { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? ExpiresAt { get; set; }

    // Navigation Properties
    public HealthcareFacilityProfile FacilityProfile { get; set; } = null!;
    public ICollection<JobApplication> Applications { get; set; } = new List<JobApplication>();
}