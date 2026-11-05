using System;
using System.Collections.Generic;
using System.Text;

namespace CampusPlacement.Domain.Entities
{
    public class InterviewSchedule
    {
        public int InterviewScheduleId { get; set; }

        public int JobApplicationId { get; set; }

        public int InterviewRoundId { get; set; }

        public DateTime InterviewDateTime { get; set; }

        public string? MeetingLink { get; set; }

        public string? Venue { get; set; }

        public JobApplication JobApplication { get; set; } = null!;

        public InterviewRound InterviewRound { get; set; } = null!;
    }
}
