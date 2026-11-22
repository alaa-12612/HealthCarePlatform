namespace Healthcare.Domain.Entities;

public class PatientProfile
{
    public int Id { get; set; }
    public string UserId { get; set; } = string.Empty;

    public DateTime? DateOfBirth { get; set; }
    public string? Gender { get; set; }
    public string? BloodType { get; set; }
    public string? ChronicConditions { get; set; }
    public string? Allergies { get; set; }
    public string? DefaultAddress { get; set; }
    public double? DefaultLatitude { get; set; }
    public double? DefaultLongitude { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation Properties
    public AppUser User { get; set; } = null!;
    public ICollection<PatientVitalLog> VitalLogs { get; set; } = new List<PatientVitalLog>();
}