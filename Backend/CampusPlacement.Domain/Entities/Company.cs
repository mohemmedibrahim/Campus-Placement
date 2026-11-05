using CampusPlacement.Domain.Enums;

namespace CampusPlacement.Domain.Entities
{
    public class Company
    {
        public int CompanyId { get; set; }

        public string CompanyName { get; set; } = string.Empty;

        public string Industry { get; set; } = string.Empty;

        public string OfficialEmail { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string? Website { get; set; }

        public string Address { get; set; } = string.Empty;

        public AccountStatus Status { get; set; } = AccountStatus.Pending;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }
    }
}