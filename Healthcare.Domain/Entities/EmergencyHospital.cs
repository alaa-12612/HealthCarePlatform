namespace Healthcare.Domain.Entities;

public class EmergencyHospital
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string EmergencyPhone { get; set; } = string.Empty;

    // GPS Coordinates for interactive map & distance calculation
    public double Latitude { get; set; }
    public double Longitude { get; set; }

    // Capabilities for filtering (Section 6 & Section 10)
    public bool Has24x7Emergency { get; set; }
    public bool HasIcu { get; set; }
    public bool HasNicu { get; set; }
    public bool HasBloodBank { get; set; }

    public bool IsActive { get; set; } = true;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}