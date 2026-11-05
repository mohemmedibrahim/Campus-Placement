namespace CampusPlacement.Domain.Entities
{
    public class Student
    {
        public int StudentId { get; set; }

        public string ApplicationUserId { get; set; } = string.Empty;

        public int CollegeId { get; set; }

        public string RegisterNumber { get; set; } = string.Empty;

        public College College { get; set; } = null!;
    }
}