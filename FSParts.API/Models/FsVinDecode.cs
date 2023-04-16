using System;
using System.Collections.Generic;

namespace FSParts.API.Models
{
    public partial class FsVinDecode
    {
        public int Id { get; set; }
        public string? Vin { get; set; }
        public string? Vindecode { get; set; }
        public DateTime? DecodeDate { get; set; }
        public string? DecodedBy { get; set; }
    }
}
