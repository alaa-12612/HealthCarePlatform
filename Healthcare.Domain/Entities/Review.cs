namespace Healthcare.Domain.Entities;

public class Review
{
    public int Id { get; set; }

    // Who is reviewing and who is being reviewed
    public string ReviewerUserId { get; set; } = string.Empty;
    public string ReviewedUserId { get; set; } = string.Empty;

    // Optional context links (Home Visit or Job/Shift)
    public int? HomeVisitRequestId { get; set; }
    public int? JobPostingId { get; set; }

    // e.g., "PatientToNurse", "FacilityToNurse", "NurseToFacility"
    public string ReviewType { get; set; } = string.Empty;

    // Rating (1 to 5) & Comment
    public int Rating { get; set; }
    public string? Comment { get; set; }

    // Moderation
    public bool IsRemovedByAdmin { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation Properties
    public AppUser Reviewer { get; set; } = null!;
    public AppUser ReviewedUser { get; set; } = null!;
    public HomeVisitRequest? HomeVisitRequest { get; set; }
    public JobPosting? JobPosting { get; set; }
}