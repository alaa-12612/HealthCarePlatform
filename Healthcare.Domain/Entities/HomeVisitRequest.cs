using Healthcare.Domain.Enums;

namespace Healthcare.Domain.Entities;

public class HomeVisitRequest
{
    public int Id { get; set; }

    // Foreign Keys
    public string PatientId { get; set; } = string.Empty;
    public string? NurseId { get; set; }

    // Booking & Timing
    public BookingType BookingType { get; set; }
    public DateTime? ScheduledDateTime { get; set; }
    public RequestStatus Status { get; set; } = RequestStatus.Pending;

    // Patient Address & Live Tracking
    public string Address { get; set; } = string.Empty;
    public double PatientLatitude { get; set; }
    public double PatientLongitude { get; set; }
    public double? NurseCurrentLatitude { get; set; }
    public double? NurseCurrentLongitude { get; set; }
    public DateTime? EstimatedArrivalTime { get; set; }

    // Prescription & Notes
    public string? PrescriptionFileUrl { get; set; }
    public string? Notes { get; set; }

    // Pricing & Payment
    public PaymentMethod PaymentMethod { get; set; }
    public decimal TotalEstimatedCost { get; set; }
    public decimal? FinalAmount { get; set; }
    public decimal? PlatformCommissionAmount { get; set; }
    public bool IsPaid { get; set; }

    // Timestamps
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? AcceptedAt { get; set; }
    public DateTime? CompletedAt { get; set; }
    public DateTime? CancelledAt { get; set; }
    public string? CancellationReason { get; set; }

    // Navigation Properties
    public AppUser Patient { get; set; } = null!;
    public AppUser? Nurse { get; set; }
    public ICollection<RequestServiceItem> ServiceItems { get; set; } = new List<RequestServiceItem>();
    public ICollection<PatientVitalLog> VitalLogs { get; set; } = new List<PatientVitalLog>();
    public ICollection<ChatMessage> ChatMessages { get; set; } = new List<ChatMessage>();
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
}