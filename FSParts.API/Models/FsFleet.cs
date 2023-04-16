using System;
using System.Collections.Generic;

namespace FSParts.API.Models
{
    public partial class FsFleet
    {
        public FsFleet()
        {
            FsSurveys = new HashSet<FsSurvey>();
        }

        public int FleetId { get; set; }
        public string? Brand { get; set; }
        public string? Name { get; set; }
        public string? Attention { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public int? CountryId { get; set; }
        public string? CountryCode { get; set; }
        public string? Phone { get; set; }
        public string? Extension { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? FleetRegistration { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? FleetDate { get; set; }
        public DateTime? LastEditDate { get; set; }
        public string Active { get; set; } = null!;
        public int? BrandId { get; set; }
        public long? CreateByUserId { get; set; }

        public virtual ICollection<FsSurvey> FsSurveys { get; set; }
    }
}
