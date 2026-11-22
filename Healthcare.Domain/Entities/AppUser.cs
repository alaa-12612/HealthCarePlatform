using Healthcare.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace Healthcare.Domain.Entities;

public class AppUser : IdentityUser
{
    public string FullName { get; set; } = string.Empty;
    public UserRole Role { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation Properties (One-to-One Profiles)
    public PatientProfile? PatientProfile { get; set; }
    public NurseProfile? NurseProfile { get; set; }
    public HealthcareFacilityProfile? FacilityProfile { get; set; }
}