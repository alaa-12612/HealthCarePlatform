namespace Healthcare.Domain.Entities;

public class PatientVitalLog
{
    public int Id { get; set; }

    // Foreign Keys
    public int PatientProfileId { get; set; }
    public int? HomeVisitRequestId { get; set; }
    public string? RecordedByNurseId { get; set; }

    // Vital Signs Measurements
    public int? BloodPressureSystolic { get; set; }  // e.g., 120
    public int? BloodPressureDiastolic { get; set; } // e.g., 80
    public double? BloodSugarLevel { get; set; }     // e.g., mg/dL
    public double? Temperature { get; set; }         // e.g., Celsius (37.0)
    public int? HeartRate { get; set; }              // e.g., BPM
    public int? OxygenSaturation { get; set; }       // e.g., SpO2 %

    public string? Notes { get; set; }
    public DateTime RecordedAt { get; set; } = DateTime.UtcNow;

    // Navigation Properties
    public PatientProfile PatientProfile { get; set; } = null!;
    public HomeVisitRequest? HomeVisitRequest { get; set; }
    public AppUser? RecordedByNurse { get; set; }
}