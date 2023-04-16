using System;
using System.Collections.Generic;

namespace FSParts.API.Models
{
    public partial class FsProvinceCode
    {
        public string? Province { get; set; }
        public string? ProvinceCode { get; set; }
        public long? CriteriaId { get; set; }
        public string? CountryCode { get; set; }
        public string? Country { get; set; }
    }
}
