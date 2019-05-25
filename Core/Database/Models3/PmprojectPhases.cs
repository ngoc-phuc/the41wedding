using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bys.Database.Models3
{
    [Table("PMProjectPhases")]
    public partial class PmprojectPhases
    {
        [Key]
        [Column("PMProjectPhaseID")]
        public int PmprojectPhaseId { get; set; }
        [Column("AAStatus")]
        [StringLength(50)]
        public string Aastatus { get; set; }
        [Column("PMProjectPhaseNo")]
        [StringLength(50)]
        public string PmprojectPhaseNo { get; set; }
        [Column("PMProjectPhaseName")]
        [StringLength(50)]
        public string PmprojectPhaseName { get; set; }
        [Column("PMProjectPhaseDesc")]
        [StringLength(255)]
        public string PmprojectPhaseDesc { get; set; }
        [Column("PMProjectPhaseRemark")]
        [StringLength(500)]
        public string PmprojectPhaseRemark { get; set; }
        [Column("FK_PMProjectID")]
        public int FkPmprojectId { get; set; }
        [Column("FK_PMPhaseTypeID")]
        public int FkPmphaseTypeId { get; set; }
        [Required]
        [Column("PMProjectPhaseStatus")]
        [StringLength(50)]
        public string PmprojectPhaseStatus { get; set; }
        [Column("PMProjectPhaseEstimatedStartDate", TypeName = "datetime")]
        public DateTime? PmprojectPhaseEstimatedStartDate { get; set; }
        [Column("PMProjectPhaseActualStartDate", TypeName = "datetime")]
        public DateTime? PmprojectPhaseActualStartDate { get; set; }
        [Column("PMProjectPhaseEstimatedEndDate", TypeName = "datetime")]
        public DateTime? PmprojectPhaseEstimatedEndDate { get; set; }
        [Column("PMProjectPhaseActualEndDate", TypeName = "datetime")]
        public DateTime? PmprojectPhaseActualEndDate { get; set; }
        [Column("PMProjectPhaseEstimatedTotalDays")]
        public int? PmprojectPhaseEstimatedTotalDays { get; set; }
        [Column("PMProjectPhaseActualTotalDays")]
        public int? PmprojectPhaseActualTotalDays { get; set; }
        [Column("PMProjectPhaseEstimatedTotalHours")]
        public int? PmprojectPhaseEstimatedTotalHours { get; set; }
        [Column("PMProjectPhaseActualTotalHours")]
        public int? PmprojectPhaseActualTotalHours { get; set; }
        [Column("PMProjectPhaseEstimatedExtendDays")]
        public int? PmprojectPhaseEstimatedExtendDays { get; set; }
        [Column("PMProjectPhaseActualExtendDays")]
        public int? PmprojectPhaseActualExtendDays { get; set; }
        [Column("PMProjectPhaseEstimatedExtendHours")]
        public int? PmprojectPhaseEstimatedExtendHours { get; set; }
        [Column("PMProjectPhaseActualExtendHours")]
        public int? PmprojectPhaseActualExtendHours { get; set; }
        [Column("PMProjectPhaseEstimatedTotalCost", TypeName = "decimal(18, 5)")]
        public decimal? PmprojectPhaseEstimatedTotalCost { get; set; }
        [Column("PMProjectPhaseActualTotalCost", TypeName = "decimal(18, 5)")]
        public decimal? PmprojectPhaseActualTotalCost { get; set; }
        [Column("FK_HRProjectPhaseOwnerEmployeeID")]
        public int? FkHrprojectPhaseOwnerEmployeeId { get; set; }
        [Column("PMProjectPhaseOwnerEmployeeName")]
        [StringLength(50)]
        public string PmprojectPhaseOwnerEmployeeName { get; set; }
        [Column("PMProjectPhaseOwnerEmployeeTel1")]
        [StringLength(50)]
        public string PmprojectPhaseOwnerEmployeeTel1 { get; set; }
        [Column("PMProjectPhaseOwnerEmployeeTel2")]
        [StringLength(50)]
        public string PmprojectPhaseOwnerEmployeeTel2 { get; set; }
        [Column("PMProjectPhaseOwnerEmployeeTel3")]
        [StringLength(50)]
        public string PmprojectPhaseOwnerEmployeeTel3 { get; set; }
        [Column("PMProjectPhaseOwnerEmployeeEmail")]
        [StringLength(50)]
        public string PmprojectPhaseOwnerEmployeeEmail { get; set; }
        [Column("PMProjectPhaseOwnerEmployeeFax")]
        [StringLength(50)]
        public string PmprojectPhaseOwnerEmployeeFax { get; set; }
        [Column("PMProjectPhaseOwnerEmployeeAddressStreet")]
        [StringLength(200)]
        public string PmprojectPhaseOwnerEmployeeAddressStreet { get; set; }
        [Column("PMProjectPhaseOwnerEmployeeAddressLine1")]
        [StringLength(200)]
        public string PmprojectPhaseOwnerEmployeeAddressLine1 { get; set; }
        [Column("PMProjectPhaseOwnerEmployeeAddressLine2")]
        [StringLength(200)]
        public string PmprojectPhaseOwnerEmployeeAddressLine2 { get; set; }
        [Column("PMProjectPhaseOwnerEmployeeAddressLine3")]
        [StringLength(200)]
        public string PmprojectPhaseOwnerEmployeeAddressLine3 { get; set; }
        [Column("PMProjectPhaseOwnerEmployeeAddressCity")]
        [StringLength(50)]
        public string PmprojectPhaseOwnerEmployeeAddressCity { get; set; }
        [Column("PMProjectPhaseOwnerEmployeeAddressPostalCode")]
        [StringLength(50)]
        public string PmprojectPhaseOwnerEmployeeAddressPostalCode { get; set; }
        [Column("PMProjectPhaseOwnerEmployeeAddressStateProvince")]
        [StringLength(50)]
        public string PmprojectPhaseOwnerEmployeeAddressStateProvince { get; set; }
        [Column("PMProjectPhaseOwnerEmployeeAddressZipCode")]
        [StringLength(50)]
        public string PmprojectPhaseOwnerEmployeeAddressZipCode { get; set; }
        [Column("PMProjectPhaseOwnerEmployeeAddressCountry")]
        [StringLength(50)]
        public string PmprojectPhaseOwnerEmployeeAddressCountry { get; set; }

        [ForeignKey("FkPmphaseTypeId")]
        [InverseProperty("PmprojectPhases")]
        public PmphaseTypes FkPmphaseType { get; set; }
        [ForeignKey("FkPmprojectId")]
        [InverseProperty("PmprojectPhases")]
        public Pmprojects FkPmproject { get; set; }
    }
}
