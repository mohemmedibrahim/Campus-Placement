using System;
using System.Collections.Generic;
using System.Text;

namespace CampusPlacement.Domain.Entities
{
    public class InterviewRound
    {
        public int InterviewRoundId { get; set; }

        public int JobId { get; set; }

        public string RoundName { get; set; } = string.Empty;

        public int RoundOrder { get; set; }

        public string? Description { get; set; }

        public JobOpening JobOpening { get; set; } = null!;
    }
}