using System;
using System.Collections.Generic;

namespace FSParts.API.Models
{
    public partial class FsState
    {
        public int Id { get; set; }
        public string? StateName { get; set; }
        public string? StateShort { get; set; }
        public string? StateCountry { get; set; }
    }
}
