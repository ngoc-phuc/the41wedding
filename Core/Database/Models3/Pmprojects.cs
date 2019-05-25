using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bys.Database.Models3
{
    [Table("PMProjects")]
    public partial class Pmprojects
    {
        public Pmprojects()
        {
            Pmcomments = new HashSet<Pmcomments>();
            PmprojectPhases = new HashSet<PmprojectPhases>();
        }

        [Key]
        [Column("PMProjectID")]
        public int PmprojectId { get; set; }
        [Column("AAStatus")]
        [StringLength(50)]
        public string Aastatus { get; set; }
        [Column("AACreatedUser")]
        [StringLength(50)]
        public string AacreatedUser { get; set; }
        [Column("AAUpdatedUser")]
        [StringLength(50)]
        public string AaupdatedUser { get; set; }
        [Column("AACreatedDate", TypeName = "datetime")]
        public DateTime? AacreatedDate { get; set; }
        [Column("AAUpdatedDate", TypeName = "datetime")]
        public DateTime? AaupdatedDate { get; set; }
        [Required]
        [Column("PMProjectNo")]
        [StringLength(50)]
        public string PmprojectNo { get; set; }
        [Column("PMProjectName")]
        [StringLength(50)]
        public string PmprojectName { get; set; }
        [Column("PMProjectDesc")]
        [StringLength(255)]
        public string PmprojectDesc { get; set; }
        [Column("PMProjectRemark")]
        [StringLength(500)]
        public string PmprojectRemark { get; set; }
        [Column("PMProjectInfo", TypeName = "ntext")]
        public string PmprojectInfo { get; set; }
        [Column("PMProjectActiveCheck")]
        public bool? PmprojectActiveCheck { get; set; }
        [Column("PMProjectStartDate", TypeName = "datetime")]
        public DateTime? PmprojectStartDate { get; set; }
        [Column("PMProjectDate", TypeName = "datetime")]
        public DateTime? PmprojectDate { get; set; }
        [Column("PMProjectMatchCode01Combo")]
        [StringLength(50)]
        public string PmprojectMatchCode01Combo { get; set; }
        [Column("PMProjectMatchCode02Combo")]
        [StringLength(50)]
        public string PmprojectMatchCode02Combo { get; set; }
        [Column("PMProjectMatchCode03Combo")]
        [StringLength(50)]
        public string PmprojectMatchCode03Combo { get; set; }
        [Column("PMProjectMatchCode04Combo")]
        [StringLength(50)]
        public string PmprojectMatchCode04Combo { get; set; }
        [Column("PMProjectMatchCode05Combo")]
        [StringLength(50)]
        public string PmprojectMatchCode05Combo { get; set; }
        [Column("PMProjectMatchCode06Combo")]
        [StringLength(50)]
        public string PmprojectMatchCode06Combo { get; set; }
        [Column("PMProjectMatchCode07Combo")]
        [StringLength(50)]
        public string PmprojectMatchCode07Combo { get; set; }
        [Column("PMProjectMatchCode08Combo")]
        [StringLength(50)]
        public string PmprojectMatchCode08Combo { get; set; }
        [Column("PMProjectMatchCode09Combo")]
        [StringLength(50)]
        public string PmprojectMatchCode09Combo { get; set; }
        [Column("PMProjectMatchCode10Combo")]
        [StringLength(50)]
        public string PmprojectMatchCode10Combo { get; set; }
        [Column("PMProjectMatchCode11Combo")]
        [StringLength(50)]
        public string PmprojectMatchCode11Combo { get; set; }
        [Column("PMProjectMatchCode12Combo")]
        [StringLength(50)]
        public string PmprojectMatchCode12Combo { get; set; }
        [Column("PMProjectType")]
        [StringLength(50)]
        public string PmprojectType { get; set; }
        [Column("PMProjectStatus")]
        [StringLength(50)]
        public string PmprojectStatus { get; set; }
        [Column("PMProjectEstimatedStartDate", TypeName = "datetime")]
        public DateTime? PmprojectEstimatedStartDate { get; set; }
        [Column("PMProjectActualStartDate", TypeName = "datetime")]
        public DateTime? PmprojectActualStartDate { get; set; }
        [Column("PMProjectEstimatedEndDate", TypeName = "datetime")]
        public DateTime? PmprojectEstimatedEndDate { get; set; }
        [Column("PMProjectActualEndDate", TypeName = "datetime")]
        public DateTime? PmprojectActualEndDate { get; set; }
        [Column("PMProjectEstimatedTotalDays")]
        public int? PmprojectEstimatedTotalDays { get; set; }
        [Column("PMProjectActualTotalDays")]
        public int? PmprojectActualTotalDays { get; set; }
        [Column("PMProjectEstimatedTotalHours")]
        public int? PmprojectEstimatedTotalHours { get; set; }
        [Column("PMProjectActualTotalHours")]
        public int? PmprojectActualTotalHours { get; set; }
        [Column("PMProjectEstimatedExtendDays")]
        public int? PmprojectEstimatedExtendDays { get; set; }
        [Column("PMProjectActualExtendDays")]
        public int? PmprojectActualExtendDays { get; set; }
        [Column("PMProjectEstimatedExtendHours")]
        public int? PmprojectEstimatedExtendHours { get; set; }
        [Column("PMProjectActualExtendHours")]
        public int? PmprojectActualExtendHours { get; set; }
        [Column("PMProjectEstimatedTotalCost", TypeName = "decimal(18, 5)")]
        public decimal? PmprojectEstimatedTotalCost { get; set; }
        [Column("PMProjectActualTotalCost", TypeName = "decimal(18, 5)")]
        public decimal? PmprojectActualTotalCost { get; set; }
        [Column("FK_HRProjectOwnerEmployeeID")]
        public int? FkHrprojectOwnerEmployeeId { get; set; }
        [Column("PMProjectOwnerEmployeeName")]
        [StringLength(50)]
        public string PmprojectOwnerEmployeeName { get; set; }
        [Column("PMProjectOwnerEmployeeTel1")]
        [StringLength(50)]
        public string PmprojectOwnerEmployeeTel1 { get; set; }
        [Column("PMProjectOwnerEmployeeTel2")]
        [StringLength(50)]
        public string PmprojectOwnerEmployeeTel2 { get; set; }
        [Column("PMProjectOwnerEmployeeTel3")]
        [StringLength(50)]
        public string PmprojectOwnerEmployeeTel3 { get; set; }
        [Column("PMProjectOwnerEmployeeEmail")]
        [StringLength(50)]
        public string PmprojectOwnerEmployeeEmail { get; set; }
        [Column("PMProjectOwnerEmployeeFax")]
        [StringLength(50)]
        public string PmprojectOwnerEmployeeFax { get; set; }
        [Column("PMProjectOwnerEmployeeAddressStreet")]
        [StringLength(200)]
        public string PmprojectOwnerEmployeeAddressStreet { get; set; }
        [Column("PMProjectOwnerEmployeeAddressLine1")]
        [StringLength(200)]
        public string PmprojectOwnerEmployeeAddressLine1 { get; set; }
        [Column("PMProjectOwnerEmployeeAddressLine2")]
        [StringLength(200)]
        public string PmprojectOwnerEmployeeAddressLine2 { get; set; }
        [Column("PMProjectOwnerEmployeeAddressLine3")]
        [StringLength(200)]
        public string PmprojectOwnerEmployeeAddressLine3 { get; set; }
        [Column("PMProjectOwnerEmployeeAddressCity")]
        [StringLength(50)]
        public string PmprojectOwnerEmployeeAddressCity { get; set; }
        [Column("PMProjectOwnerEmployeeAddressPostalCode")]
        [StringLength(50)]
        public string PmprojectOwnerEmployeeAddressPostalCode { get; set; }
        [Column("PMProjectOwnerEmployeeAddressStateProvince")]
        [StringLength(50)]
        public string PmprojectOwnerEmployeeAddressStateProvince { get; set; }
        [Column("PMProjectOwnerEmployeeAddressZipCode")]
        [StringLength(50)]
        public string PmprojectOwnerEmployeeAddressZipCode { get; set; }
        [Column("PMProjectOwnerEmployeeAddressCountry")]
        [StringLength(50)]
        public string PmprojectOwnerEmployeeAddressCountry { get; set; }
        [Column("FK_PMProjectTypeID")]
        public int? FkPmprojectTypeId { get; set; }
        [Column("PMProjectIntrodurePerson")]
        [StringLength(256)]
        public string PmprojectIntrodurePerson { get; set; }
        [Column("PMProjectAddress")]
        [StringLength(512)]
        public string PmprojectAddress { get; set; }
        [Column("FK_HREmployeeID")]
        public int? FkHremployeeId { get; set; }
        [Column("PMProjectPriority")]
        [StringLength(50)]
        public string PmprojectPriority { get; set; }

        [ForeignKey("FkHremployeeId")]
        [InverseProperty("PmprojectsFkHremployee")]
        public Hremployees FkHremployee { get; set; }
        [ForeignKey("FkHrprojectOwnerEmployeeId")]
        [InverseProperty("PmprojectsFkHrprojectOwnerEmployee")]
        public Hremployees FkHrprojectOwnerEmployee { get; set; }
        [ForeignKey("FkPmprojectTypeId")]
        [InverseProperty("Pmprojects")]
        public PmprojectTypes FkPmprojectType { get; set; }
        [InverseProperty("FkPmproject")]
        public ICollection<Pmcomments> Pmcomments { get; set; }
        [InverseProperty("FkPmproject")]
        public ICollection<PmprojectPhases> PmprojectPhases { get; set; }
    }
}
