namespace Healthcare.Domain.Entities;

public class NurseWallet
{
    public int Id { get; set; }

    // Foreign Key (One-to-One with NurseProfile)
    public int NurseProfileId { get; set; }

    // Balances
    public decimal AvailableBalance { get; set; }
    public decimal PendingEarnings { get; set; }
    public string Currency { get; set; } = "EGP";

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    // Navigation Properties
    public NurseProfile NurseProfile { get; set; } = null!;
    public ICollection<WalletTransaction> Transactions { get; set; } = new List<WalletTransaction>();
}