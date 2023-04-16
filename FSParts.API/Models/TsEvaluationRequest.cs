using System;
using System.Collections.Generic;

namespace FSParts.API.Models
{
    public partial class TsEvaluationRequest
    {
        public int RequestId { get; set; }
        public string? EvaluationSerialNo { get; set; }
        public string? ClaimSerialNo { get; set; }
        public string? DistManager { get; set; }
        public string? RegManager { get; set; }
        public string? FilterNumber { get; set; }
        public string? RequestDate { get; set; }
        public string? District { get; set; }
        public string? EquipOwner { get; set; }
        public string? EquipStreet { get; set; }
        public string? EquipCity { get; set; }
        public string? EquipState { get; set; }
        public string? EquipZip { get; set; }
        public string? EquipContact { get; set; }
        public string? EquipPhone { get; set; }
        public string? EquipEmail { get; set; }
        public string? JobName { get; set; }
        public string? JobStreet { get; set; }
        public string? JobCity { get; set; }
        public string? JobState { get; set; }
        public string? JobZip { get; set; }
        public string? JobContact { get; set; }
        public string? JobPhone { get; set; }
        public string? JobEmail { get; set; }
        public string? InstName { get; set; }
        public string? InstStreet { get; set; }
        public string? InstCity { get; set; }
        public string? InstState { get; set; }
        public string? InstZip { get; set; }
        public string? InstContact { get; set; }
        public string? InstPhone { get; set; }
        public string? InstEmail { get; set; }
        public string? FilterPartNumber { get; set; }
        public string? FilterDateCode { get; set; }
        public string? FilterDateInstall { get; set; }
        public string? FilterDateRemoval { get; set; }
        public string? FilterDateOccurence { get; set; }
        public string? FilterMiles { get; set; }
        public string? FilterHours { get; set; }
        public string? Equipmake { get; set; }
        public string? EquipModel { get; set; }
        public string? EquipYear { get; set; }
        public string? EquipEngSize { get; set; }
        public string? EquipEngFuel { get; set; }
        public string? EquipVin { get; set; }
        public string? EquipUnit { get; set; }
        public string? VehTypeService { get; set; }
        public string? VehMiles { get; set; }
        public string? VehHours { get; set; }
        public string? NewRebuilt { get; set; }
        public string? VehAddInfo { get; set; }
        public string? SendListItems { get; set; }
        public string? SendCarrier { get; set; }
        public string? SendTrackNumber { get; set; }
        public string? SendDate { get; set; }
        public string? SendReason { get; set; }
        public string? ClaimRequestReceivedDate { get; set; }
        public string? ClaimRequestReceivedBy { get; set; }
        public string? ClaimRequestor { get; set; }
        public string? ClaimApprovedBy { get; set; }
        public string? ClaimApprovedDate { get; set; }
        public string? ClaimRequestDate { get; set; }
        public int? ClaimRequestNumber { get; set; }
        public string? ClaimRequestorCompany { get; set; }
        public string? ClaimStatus { get; set; }
        public string? Active { get; set; }
        public int BrandId { get; set; }
    }
}
