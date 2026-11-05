using System;
using System.Collections.Generic;
using System.Text;

namespace CampusPlacement.Domain.Entities
{
    public class RecruitmentDrive
    {
        public int RecruitmentDriveId { get; set; }

        public int JobId { get; set; }

        public DateTime DriveDate { get; set; }

        public string Venue { get; set; } = string.Empty;

        public string? Description { get; set; }

        public JobOpening JobOpening { get; set; } = null!;
    }
}