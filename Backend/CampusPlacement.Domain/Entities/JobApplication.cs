namespace CampusPlacement.Domain.Entities
{
    public class JobApplication
    {
        public int JobApplicationId { get; set; }

        public int StudentId { get; set; }

        public int JobId { get; set; }

        public DateTime AppliedAt { get; set; } = DateTime.UtcNow;

        public Student Student { get; set; } = null!;

        public JobOpening JobOpening { get; set; } = null!;
    }
}