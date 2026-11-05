namespace CampusPlacement.Domain.Entities
{
    public class CompanyHR
    {
        public int CompanyHRId { get; set; }

        public string ApplicationUserId { get; set; } = string.Empty;

        public int CompanyId { get; set; }

        public Company Company { get; set; } = null!;
    }
}