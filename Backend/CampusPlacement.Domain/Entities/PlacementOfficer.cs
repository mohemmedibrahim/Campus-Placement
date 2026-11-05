using CampusPlacement.Domain.Entities;

namespace CampusPlacement.Domain.Entities
{
    public class PlacementOfficer
    {
        // Primary Key
        public int PlacementOfficerId { get; set; }

        // Foreign Key - ApplicationUser
        public string ApplicationUserId { get; set; } = string.Empty;

        // Foreign Key - College
        public int CollegeId { get; set; }

        // Navigation Property
        public College College { get; set; } = null!;
    }
}