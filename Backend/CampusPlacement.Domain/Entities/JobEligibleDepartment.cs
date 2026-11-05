using System;
using System.Collections.Generic;
using System.Text;

namespace CampusPlacement.Domain.Entities
{
    public class JobEligibleDepartment
    {
        public int JobEligibleDepartmentId { get; set; }

        public int JobId { get; set; }

        public string DepartmentName { get; set; } = string.Empty;

        public JobOpening JobOpening { get; set; } = null!;
    }
}