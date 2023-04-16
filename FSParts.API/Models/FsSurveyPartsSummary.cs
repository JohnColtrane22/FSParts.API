using System;
using System.Collections.Generic;

namespace FSParts.API.Models
{
    public partial class FsSurveyPartsSummary
    {
        public long SurveySummaryRowId { get; set; }
        public int? SurveyId { get; set; }
        public int? PartId { get; set; }
        public string? Partnumber { get; set; }
        public int? FleetBidItemId { get; set; }
        public int? Quantity { get; set; }
        public int? StoreStockMin { get; set; }
        public int? StoreStockMax { get; set; }
        public int? CustomerStockMin { get; set; }
        public int? CustomerStockMax { get; set; }
        public string? PartType { get; set; }
        public int? SuggestedQty { get; set; }
        public string? Brand { get; set; }
        public string? Comment { get; set; }
        public string? CompPart { get; set; }
        public int? BrandId { get; set; }

        public virtual FsSurvey? Survey { get; set; }
    }
}
