using System;
using System.Collections.Generic;
using System.Text;

namespace CampusPlacement.Domain.Entities
{
    public class JobEligibleGraduationYear
    {
        public int JobEligibleGraduationYearId { get; set; }

        public int JobId { get; set; }

        public int GraduationYear { get; set; }

        public JobOpening JobOpening { get; set; } = null!;
    }
}
