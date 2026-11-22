using Healthcare.Domain.Enums;

namespace Healthcare.Domain.Entities;

public class HealthcareFacilityProfile
{
    public int Id { get; set; }
    public string UserId { get; set; } = string.Empty;

    public string FacilityName { get; set; } = string.Empty;
    public FacilityType FacilityType { get; set; }
    public string Address { get; set; } = string.Empty;
    public string ContactPhone { get; set; } = string.Empty;
    public string? Description { get; set; }

    // Optional coordinates if needed for nearby urgent shift matching
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }

    // Cached rating summary for fast profile & ranking display
    public double AverageRating { get; set; }
    public int TotalReviews { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation Properties
    public AppUser User { get; set; } = null!;
    public ICollection<JobPosting> JobPostings { get; set; } = new List<JobPosting>();
}