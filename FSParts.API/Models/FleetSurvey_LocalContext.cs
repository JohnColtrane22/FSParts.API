using System;
using System.Collections.Generic;
using FSParts.API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FSParts.API.Models
{
    public partial class FleetSurvey_LocalContext : IdentityDbContext<User>
    {
        public FleetSurvey_LocalContext()
        {
        }

        public FleetSurvey_LocalContext(DbContextOptions<FleetSurvey_LocalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FsFleet> FsFleets { get; set; } = null!;
        public virtual DbSet<FsJobber> FsJobbers { get; set; } = null!;
        public virtual DbSet<FsProvinceCode> FsProvinceCodes { get; set; } = null!;
        public virtual DbSet<FsState> FsStates { get; set; } = null!;
        public virtual DbSet<FsSurvey> FsSurveys { get; set; } = null!;
        public virtual DbSet<FsSurveyPartsSummary> FsSurveyPartsSummaries { get; set; } = null!;
        public virtual DbSet<FsSurveyVehicle> FsSurveyVehicles { get; set; } = null!;
        public virtual DbSet<FsSurveyVehiclePart> FsSurveyVehicleParts { get; set; } = null!;
        public virtual DbSet<FsUser> FsUsers { get; set; } = null!;
        public virtual DbSet<FsVinDecode> FsVinDecodes { get; set; } = null!;
        public virtual DbSet<TsEvaluationRequest> TsEvaluationRequests { get; set; } = null!;
        public virtual DbSet<WpcAcesVehicleEngineYear> WpcAcesVehicleEngineYears { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole { Name = "Member", NormalizedName = "MEMBER" },
                    new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" }
                );
            modelBuilder.Entity<FsFleet>(entity =>
            {
                entity.HasKey(e => e.FleetId)
                    .HasName("PK_dbo.FS_Fleet");

                entity.ToTable("FS_Fleet");

                entity.Property(e => e.FleetId).HasColumnName("FleetID");

                entity.Property(e => e.Active).HasMaxLength(1);

                entity.Property(e => e.AddressLine1).HasMaxLength(100);

                entity.Property(e => e.AddressLine2).HasMaxLength(100);

                entity.Property(e => e.Attention).HasMaxLength(100);

                entity.Property(e => e.Brand).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.CountryCode).HasMaxLength(10);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreateByUserId).HasColumnName("CreateByUserID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Extension).HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(100);

                entity.Property(e => e.FleetDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FleetRegistration).HasMaxLength(100);

                entity.Property(e => e.LastEditDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Phone).HasMaxLength(100);

                entity.Property(e => e.State).HasMaxLength(100);

                entity.Property(e => e.ZipCode).HasMaxLength(100);
            });

            modelBuilder.Entity<FsJobber>(entity =>
            {
                entity.HasKey(e => e.JobberId)
                    .HasName("PK_dbo.FS_Jobber");

                entity.ToTable("FS_Jobber");

                entity.Property(e => e.JobberId).HasColumnName("JobberID");

                entity.Property(e => e.Active).HasMaxLength(1);

                entity.Property(e => e.AddresLine1).HasMaxLength(100);

                entity.Property(e => e.AddressLine2).HasMaxLength(100);

                entity.Property(e => e.Attention).HasMaxLength(100);

                entity.Property(e => e.Brand).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.CountryCode).HasMaxLength(10);

                entity.Property(e => e.CreateByUserId).HasColumnName("CreateByUserID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Extension).HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(100);

                entity.Property(e => e.JobberDate).HasColumnType("smalldatetime");

                entity.Property(e => e.JobberSupplier).HasMaxLength(100);

                entity.Property(e => e.LastEditDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Phone).HasMaxLength(100);

                entity.Property(e => e.State).HasMaxLength(100);

                entity.Property(e => e.ZipCode).HasMaxLength(100);
            });

            modelBuilder.Entity<FsProvinceCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FS_ProvinceCodes");

                entity.Property(e => e.Country)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinceCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FsState>(entity =>
            {
                entity.ToTable("FS_States");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.StateCountry).HasMaxLength(50);

                entity.Property(e => e.StateName).HasMaxLength(50);

                entity.Property(e => e.StateShort).HasMaxLength(50);
            });

            modelBuilder.Entity<FsSurvey>(entity =>
            {
                entity.HasKey(e => e.SurveyId)
                    .HasName("PK_dbo.FS_Surveys");

                entity.ToTable("FS_Surveys");

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");

                entity.Property(e => e.Active).HasMaxLength(1);

                entity.Property(e => e.Brand).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("smalldatetime");

                entity.Property(e => e.DateRevised).HasColumnType("smalldatetime");

                entity.Property(e => e.FleetId).HasColumnName("FleetID");

                entity.Property(e => e.Import).HasMaxLength(10);

                entity.Property(e => e.JobberId).HasColumnName("JobberID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.SuveyGuid).HasColumnName("SuveyGUID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Fleet)
                    .WithMany(p => p.FsSurveys)
                    .HasForeignKey(d => d.FleetId)
                    .HasConstraintName("FK_dbo.FS_Surveys_dbo.FS_Fleet_FleetID");

                entity.HasOne(d => d.Jobber)
                    .WithMany(p => p.FsSurveys)
                    .HasForeignKey(d => d.JobberId)
                    .HasConstraintName("FK_dbo.FS_Surveys_dbo.FS_Jobber_JobberID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FsSurveys)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.FS_Surveys_dbo.FS_Users_UserID");
            });

            modelBuilder.Entity<FsSurveyPartsSummary>(entity =>
            {
                entity.HasKey(e => e.SurveySummaryRowId)
                    .HasName("PK_dbo.FS_SurveyPartsSummary");

                entity.ToTable("FS_SurveyPartsSummary");

                entity.Property(e => e.SurveySummaryRowId).HasColumnName("SurveySummaryRowID");

                entity.Property(e => e.Brand).HasMaxLength(50);

                entity.Property(e => e.Comment).HasMaxLength(400);

                entity.Property(e => e.CompPart).HasMaxLength(100);

                entity.Property(e => e.FleetBidItemId).HasColumnName("FleetBidItemID");

                entity.Property(e => e.PartId).HasColumnName("PartID");

                entity.Property(e => e.PartType).HasMaxLength(50);

                entity.Property(e => e.Partnumber).HasMaxLength(50);

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");

                entity.HasOne(d => d.Survey)
                    .WithMany(p => p.FsSurveyPartsSummaries)
                    .HasForeignKey(d => d.SurveyId)
                    .HasConstraintName("FK_dbo.FS_SurveyPartsSummary_dbo.FS_Surveys_SurveyID");
            });

            modelBuilder.Entity<FsSurveyVehicle>(entity =>
            {
                entity.HasKey(e => e.SurveyVehicalId)
                    .HasName("PK_dbo.FS_SurveyVehicles");

                entity.ToTable("FS_SurveyVehicles");

                entity.Property(e => e.SurveyVehicalId).HasColumnName("SurveyVehicalID");

                entity.Property(e => e.Agpmsstatus).HasColumnName("AGPMSStatus");

                entity.Property(e => e.Comments).HasMaxLength(4000);

                entity.Property(e => e.EngCode).HasMaxLength(50);

                entity.Property(e => e.Engine).HasMaxLength(100);

                entity.Property(e => e.EngineId).HasColumnName("EngineID");

                entity.Property(e => e.LastEditDate).HasColumnType("datetime");

                entity.Property(e => e.Make).HasMaxLength(100);

                entity.Property(e => e.MakeId).HasColumnName("MakeID");

                entity.Property(e => e.MakeModel).HasMaxLength(100);

                entity.Property(e => e.Model).HasMaxLength(100);

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.ModelYear).HasMaxLength(100);

                entity.Property(e => e.Notes).HasMaxLength(4000);

                entity.Property(e => e.Position).HasMaxLength(100);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.SubModel).HasMaxLength(100);

                entity.Property(e => e.SubmodelId).HasColumnName("SubmodelID");

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");

                entity.Property(e => e.Units).HasMaxLength(100);

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.Property(e => e.VehicleSku)
                    .HasMaxLength(100)
                    .HasColumnName("VehicleSKU");

                entity.HasOne(d => d.Survey)
                    .WithMany(p => p.FsSurveyVehicles)
                    .HasForeignKey(d => d.SurveyId)
                    .HasConstraintName("FK_dbo.FS_SurveyVehicles_dbo.FS_Surveys_SurveyID");
            });

            modelBuilder.Entity<FsSurveyVehiclePart>(entity =>
            {
                entity.HasKey(e => e.SurveyVehicalPartsId)
                    .HasName("PK_dbo.FS_SurveyVehicleParts");

                entity.ToTable("FS_SurveyVehicleParts");

                entity.Property(e => e.SurveyVehicalPartsId).HasColumnName("SurveyVehicalPartsID");

                entity.Property(e => e.BrandDesc).HasMaxLength(50);

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.Comments).HasMaxLength(1000);

                entity.Property(e => e.CompBrandDesc).HasMaxLength(50);

                entity.Property(e => e.CompBrandId).HasColumnName("CompBrandID");

                entity.Property(e => e.CompPartId).HasColumnName("CompPartID");

                entity.Property(e => e.CompPartNumber).HasMaxLength(50);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.LastEditDate).HasColumnType("datetime");

                entity.Property(e => e.Misc).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(1000);

                entity.Property(e => e.PartId).HasColumnName("PartID");

                entity.Property(e => e.PartNumber).HasMaxLength(50);

                entity.Property(e => e.PartTypeDesc).HasMaxLength(50);

                entity.Property(e => e.PartTypeId).HasColumnName("PartTypeID");

                entity.Property(e => e.Position).HasMaxLength(50);

                entity.Property(e => e.StyleDesc).HasMaxLength(50);

                entity.Property(e => e.StyleId).HasColumnName("StyleID");

                entity.Property(e => e.SurveyVehicalId).HasColumnName("SurveyVehicalID");

                entity.HasOne(d => d.SurveyVehical)
                    .WithMany(p => p.FsSurveyVehicleParts)
                    .HasForeignKey(d => d.SurveyVehicalId)
                    .HasConstraintName("FK_FS_SurveyVehicleParts_FS_SurveyVehicles");
            });

            modelBuilder.Entity<FsUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_dbo.FS_Users");

                entity.ToTable("FS_Users");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Address1)
                    .HasMaxLength(100)
                    .HasColumnName("address_1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .HasColumnName("address_2");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .HasColumnName("city");

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .HasColumnName("company");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .HasColumnName("country")
                    .HasDefaultValueSql("((170))");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Fax)
                    .HasMaxLength(25)
                    .HasColumnName("fax");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .HasColumnName("password");

                entity.Property(e => e.PasswordHint)
                    .HasMaxLength(255)
                    .HasColumnName("password_hint");

                entity.Property(e => e.Phone)
                    .HasMaxLength(25)
                    .HasColumnName("phone");

                entity.Property(e => e.RepCode)
                    .HasMaxLength(10)
                    .HasColumnName("rep_code");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .HasColumnName("state");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("title");

                entity.Property(e => e.Zip)
                    .HasMaxLength(50)
                    .HasColumnName("zip");
            });

            modelBuilder.Entity<FsVinDecode>(entity =>
            {
                entity.ToTable("FS_VinDecode");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DecodeDate).HasColumnType("datetime");

                entity.Property(e => e.DecodedBy).HasMaxLength(50);

                entity.Property(e => e.Vin)
                    .HasMaxLength(50)
                    .HasColumnName("VIN");

                entity.Property(e => e.Vindecode).HasColumnName("VINDecode");
            });

            modelBuilder.Entity<TsEvaluationRequest>(entity =>
            {
                entity.HasKey(e => e.RequestId)
                    .HasName("PK_dbo.TS_EvaluationRequest");

                entity.ToTable("TS_EvaluationRequest");

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.Active).HasMaxLength(1);

                entity.Property(e => e.ClaimApprovedBy).HasMaxLength(50);

                entity.Property(e => e.ClaimApprovedDate).HasMaxLength(20);

                entity.Property(e => e.ClaimRequestDate).HasMaxLength(20);

                entity.Property(e => e.ClaimRequestReceivedBy).HasMaxLength(50);

                entity.Property(e => e.ClaimRequestReceivedDate).HasMaxLength(20);

                entity.Property(e => e.ClaimRequestor).HasMaxLength(50);

                entity.Property(e => e.ClaimRequestorCompany).HasMaxLength(20);

                entity.Property(e => e.ClaimSerialNo).HasMaxLength(50);

                entity.Property(e => e.ClaimStatus).HasMaxLength(50);

                entity.Property(e => e.DistManager).HasMaxLength(50);

                entity.Property(e => e.District).HasMaxLength(50);

                entity.Property(e => e.EquipCity).HasMaxLength(50);

                entity.Property(e => e.EquipContact).HasMaxLength(50);

                entity.Property(e => e.EquipEmail).HasMaxLength(50);

                entity.Property(e => e.EquipEngFuel).HasMaxLength(10);

                entity.Property(e => e.EquipEngSize).HasMaxLength(50);

                entity.Property(e => e.EquipModel).HasMaxLength(50);

                entity.Property(e => e.EquipOwner).HasMaxLength(100);

                entity.Property(e => e.EquipPhone).HasMaxLength(25);

                entity.Property(e => e.EquipState).HasMaxLength(25);

                entity.Property(e => e.EquipStreet).HasMaxLength(100);

                entity.Property(e => e.EquipUnit).HasMaxLength(50);

                entity.Property(e => e.EquipVin)
                    .HasMaxLength(50)
                    .HasColumnName("EquipVIN");

                entity.Property(e => e.EquipYear).HasMaxLength(10);

                entity.Property(e => e.EquipZip).HasMaxLength(20);

                entity.Property(e => e.Equipmake).HasMaxLength(50);

                entity.Property(e => e.EvaluationSerialNo).HasMaxLength(50);

                entity.Property(e => e.FilterDateCode).HasMaxLength(50);

                entity.Property(e => e.FilterDateInstall).HasMaxLength(20);

                entity.Property(e => e.FilterDateOccurence).HasMaxLength(20);

                entity.Property(e => e.FilterDateRemoval).HasMaxLength(20);

                entity.Property(e => e.FilterHours).HasMaxLength(20);

                entity.Property(e => e.FilterMiles).HasMaxLength(20);

                entity.Property(e => e.FilterNumber).HasMaxLength(50);

                entity.Property(e => e.FilterPartNumber).HasMaxLength(50);

                entity.Property(e => e.InstCity).HasMaxLength(50);

                entity.Property(e => e.InstContact).HasMaxLength(50);

                entity.Property(e => e.InstEmail).HasMaxLength(50);

                entity.Property(e => e.InstName).HasMaxLength(100);

                entity.Property(e => e.InstPhone).HasMaxLength(25);

                entity.Property(e => e.InstState).HasMaxLength(25);

                entity.Property(e => e.InstStreet).HasMaxLength(100);

                entity.Property(e => e.InstZip).HasMaxLength(20);

                entity.Property(e => e.JobCity).HasMaxLength(50);

                entity.Property(e => e.JobContact).HasMaxLength(50);

                entity.Property(e => e.JobEmail).HasMaxLength(50);

                entity.Property(e => e.JobName).HasMaxLength(100);

                entity.Property(e => e.JobPhone).HasMaxLength(25);

                entity.Property(e => e.JobState).HasMaxLength(25);

                entity.Property(e => e.JobStreet).HasMaxLength(100);

                entity.Property(e => e.JobZip).HasMaxLength(20);

                entity.Property(e => e.NewRebuilt).HasMaxLength(10);

                entity.Property(e => e.RegManager).HasMaxLength(50);

                entity.Property(e => e.RequestDate).HasMaxLength(50);

                entity.Property(e => e.SendCarrier).HasMaxLength(20);

                entity.Property(e => e.SendDate).HasMaxLength(20);

                entity.Property(e => e.SendListItems).HasMaxLength(256);

                entity.Property(e => e.SendTrackNumber).HasMaxLength(50);

                entity.Property(e => e.VehAddInfo).HasMaxLength(512);

                entity.Property(e => e.VehHours).HasMaxLength(10);

                entity.Property(e => e.VehMiles).HasMaxLength(10);

                entity.Property(e => e.VehTypeService).HasMaxLength(50);
            });

            modelBuilder.Entity<WpcAcesVehicleEngineYear>(entity =>
            {
                entity.ToTable("wpc_AcesVehicleEngineYear");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcesEngMfr).HasMaxLength(100);

                entity.Property(e => e.AcesEngineConfigId).HasColumnName("AcesEngineConfigID");

                entity.Property(e => e.AcesVehicleId).HasColumnName("AcesVehicleID");

                entity.Property(e => e.AcesYearId).HasColumnName("AcesYearID");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
