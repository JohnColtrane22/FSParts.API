using System;
using System.Collections.Generic;

namespace FSParts.API.Models
{
    public partial class FsSurvey
    {
        public FsSurvey()
        {
            FsSurveyPartsSummaries = new HashSet<FsSurveyPartsSummary>();
            FsSurveyVehicles = new HashSet<FsSurveyVehicle>();
        }

        public int SurveyId { get; set; }
        public Guid? SuveyGuid { get; set; }
        public int? FleetId { get; set; }
        public int? JobberId { get; set; }
        public long? UserId { get; set; }
        public string? Name { get; set; }
        public string Brand { get; set; } = null!;
        public string? Notes { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateRevised { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Active { get; set; } = null!;
        public string? Import { get; set; }
        public int? LastSortCol { get; set; }
        public int? LastSortDesc { get; set; }
        public int? BrandId { get; set; }

        public virtual FsFleet? Fleet { get; set; }
        public virtual FsJobber? Jobber { get; set; }
        public virtual FsUser? User { get; set; }
        public virtual ICollection<FsSurveyPartsSummary> FsSurveyPartsSummaries { get; set; }
        public virtual ICollection<FsSurveyVehicle> FsSurveyVehicles { get; set; }
    }
}
