using System;
using System.Collections.Generic;

namespace FSParts.API.Models
{
    public partial class WpcAcesVehicleEngineYear
    {
        public int Id { get; set; }
        public int? AcesVehicleId { get; set; }
        public int? VehicleId { get; set; }
        public int? AcesEngineConfigId { get; set; }
        public int? AcesYearId { get; set; }
        public string? AcesEngMfr { get; set; }
    }
}
