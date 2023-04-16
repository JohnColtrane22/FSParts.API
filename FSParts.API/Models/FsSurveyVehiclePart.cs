using System;
using System.Collections.Generic;

namespace FSParts.API.Models
{
    public partial class FsSurveyVehiclePart
    {
        public int SurveyVehicalPartsId { get; set; }
        public int? SurveyVehicalId { get; set; }
        public int? PartId { get; set; }
        public int? BrandId { get; set; }
        public int Qty { get; set; }
        public string? Position { get; set; }
        public string? PartNumber { get; set; }
        public string? BrandDesc { get; set; }
        public int? CompBrandId { get; set; }
        public int? CompPartId { get; set; }
        public string? CompBrandDesc { get; set; }
        public string? CompPartNumber { get; set; }
        public int? PartTypeId { get; set; }
        public string? PartTypeDesc { get; set; }
        public int? StyleId { get; set; }
        public string? StyleDesc { get; set; }
        public bool? OriginalEquipment { get; set; }
        public bool? HidePrint { get; set; }
        public string? Misc { get; set; }
        public string? Comments { get; set; }
        public string? Notes { get; set; }
        public DateTime? LastEditDate { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual FsSurveyVehicle? SurveyVehical { get; set; }
    }
}
