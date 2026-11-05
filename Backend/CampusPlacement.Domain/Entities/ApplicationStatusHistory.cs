using System;
using System.Collections.Generic;
using System.Text;

namespace CampusPlacement.Domain.Entities
{
    public class ApplicationStatusHistory
    {
        public int ApplicationStatusHistoryId { get; set; }

        public int JobApplicationId { get; set; }

        public string PreviousStatus { get; set; } = string.Empty;

        public string NewStatus { get; set; } = string.Empty;

        public string ChangedByUserId { get; set; } = string.Empty;

        public DateTime ChangedAt { get; set; } = DateTime.UtcNow;

        public string? Remarks { get; set; }

        public JobApplication JobApplication { get; set; } = null!;
    }
}
