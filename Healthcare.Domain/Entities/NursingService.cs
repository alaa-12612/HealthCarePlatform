namespace Healthcare.Domain.Entities;

public class NursingService
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty; // e.g., Injections, IV Cannula, Wound Dressing, Vital Signs, Elderly Care
    public string Description { get; set; } = string.Empty;
    public decimal BasePrice { get; set; }
    public int EstimatedDurationMinutes { get; set; }
    public string RequiredSpecialty { get; set; } = string.Empty;

    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }

    // Navigation Properties
    public ICollection<RequestServiceItem> RequestServiceItems { get; set; } = new List<RequestServiceItem>();
}