using System;
using System.Collections.Generic;

namespace FSParts.API.Models
{
    public partial class FsSurveyVehicle
    {
        public FsSurveyVehicle()
        {
            FsSurveyVehicleParts = new HashSet<FsSurveyVehiclePart>();
        }

        public int SurveyVehicalId { get; set; }
        public int? SurveyId { get; set; }
        public string? MakeModel { get; set; }
        public int? VehicleId { get; set; }
        public int? SectionId { get; set; }
        public int? MakeId { get; set; }
        public int? ModelId { get; set; }
        public int? SubmodelId { get; set; }
        public int? EngineId { get; set; }
        public string? Engine { get; set; }
        public bool? Farm { get; set; }
        public string? ModelYear { get; set; }
        public string? Comments { get; set; }
        public string? Notes { get; set; }
        public string? VehicleSku { get; set; }
        public string? Position { get; set; }
        public string? Units { get; set; }
        public DateTime? LastEditDate { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? SubModel { get; set; }
        public bool? NewVehicle { get; set; }
        public int? Agpmsstatus { get; set; }
        public string? EngCode { get; set; }

        public virtual FsSurvey? Survey { get; set; }
        public virtual ICollection<FsSurveyVehiclePart> FsSurveyVehicleParts { get; set; }
    }
}
