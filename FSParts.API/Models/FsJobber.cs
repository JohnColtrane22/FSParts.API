using System;
using System.Collections.Generic;

namespace FSParts.API.Models
{
    public partial class FsJobber
    {
        public FsJobber()
        {
            FsSurveys = new HashSet<FsSurvey>();
        }

        public int JobberId { get; set; }
        public string? Brand { get; set; }
        public string? Name { get; set; }
        public string? Attention { get; set; }
        public string? AddresLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public int? Country { get; set; }
        public string? CountryCode { get; set; }
        public string? Phone { get; set; }
        public string? Extension { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? JobberSupplier { get; set; }
        public DateTime? JobberDate { get; set; }
        public DateTime? LastEditDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? Active { get; set; }
        public int? BrandId { get; set; }
        public long? CreateByUserId { get; set; }

        public virtual ICollection<FsSurvey> FsSurveys { get; set; }
    }
}
