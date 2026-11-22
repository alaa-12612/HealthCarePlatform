using Healthcare.Domain.Enums;

namespace Healthcare.Domain.Entities;

public class WalletTransaction
{
    public int Id { get; set; }

    // Foreign Key
    public int NurseWalletId { get; set; }

    // Transaction Details & Commission
    public TransactionType TransactionType { get; set; }
    public decimal GrossAmount { get; set; }
    public decimal CommissionPercentage { get; set; }
    public decimal CommissionAmount { get; set; }
    public decimal NetAmount { get; set; }

    // Optional reference to the source visit or shift
    public int? HomeVisitRequestId { get; set; }
    public int? JobPostingId { get; set; }
    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation Properties
    public NurseWallet NurseWallet { get; set; } = null!;
    public HomeVisitRequest? HomeVisitRequest { get; set; }
    public JobPosting? JobPosting { get; set; }
}