namespace Healthcare.Domain.Entities;

public class ChatMessage
{
    public int Id { get; set; }

    // Foreign Keys
    public int HomeVisitRequestId { get; set; }
    public string SenderId { get; set; } = string.Empty;
    public string ReceiverId { get; set; } = string.Empty;

    // Message Content & Status
    public string MessageText { get; set; } = string.Empty;
    public bool IsRead { get; set; }
    public DateTime SentAt { get; set; } = DateTime.UtcNow;

    // Navigation Properties
    public HomeVisitRequest HomeVisitRequest { get; set; } = null!;
    public AppUser Sender { get; set; } = null!;
    public AppUser Receiver { get; set; } = null!;
}