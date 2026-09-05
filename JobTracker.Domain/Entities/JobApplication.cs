using JobTracker.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTracker.Domain.Entities
{
    public class JobApplication
    {
        public int Id { get; set; }

        public string CompanyName { get; set; } = string.Empty;

        public string JobTitle { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;

        public string JobType { get; set; } = string.Empty;

        public DateTime AppliedDate { get; set; }

        public ApplicationStatus Status { get; set; }

        public string? Notes { get; set; }

        public string? JobLink { get; set; }
    }
}
