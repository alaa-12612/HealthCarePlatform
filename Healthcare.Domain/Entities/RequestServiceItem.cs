namespace Healthcare.Domain.Entities;

public class RequestServiceItem
{
    public int Id { get; set; }

    // Foreign Keys
    public int HomeVisitRequestId { get; set; }
    public int NursingServiceId { get; set; }

    // Quantity & Price Snapshot at Booking Time
    public int Quantity { get; set; } = 1;
    public decimal UnitPriceAtBooking { get; set; }
    public int EstimatedDurationMinutesAtBooking { get; set; }

    // Navigation Properties
    public HomeVisitRequest HomeVisitRequest { get; set; } = null!;
    public NursingService NursingService { get; set; } = null!;
}