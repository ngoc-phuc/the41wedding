using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bys.Database.Models3
{
    [Table("PMPhaseTypes")]
    public partial class PmphaseTypes
    {
        public PmphaseTypes()
        {
            PmprojectPhases = new HashSet<PmprojectPhases>();
        }

        [Key]
        [Column("PMPhaseTypeID")]
        public int PmphaseTypeId { get; set; }
        [Column("AAStatus")]
        [StringLength(10)]
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
        [Column("PMPhaseTypeNo")]
        [StringLength(50)]
        public string PmphaseTypeNo { get; set; }
        [Column("PMPhaseTypeName")]
        [StringLength(50)]
        public string PmphaseTypeName { get; set; }
        [Column("PMPhaseTypeDesc")]
        [StringLength(255)]
        public string PmphaseTypeDesc { get; set; }
        [Column("PMPhaseTypeInfo", TypeName = "ntext")]
        public string PmphaseTypeInfo { get; set; }
        [Column("PMPhaseTypeRemark")]
        [StringLength(500)]
        public string PmphaseTypeRemark { get; set; }
        [Column("FK_PMProjectTypeID")]
        public int? FkPmprojectTypeId { get; set; }

        [ForeignKey("FkPmprojectTypeId")]
        [InverseProperty("PmphaseTypes")]
        public PmprojectTypes FkPmprojectType { get; set; }
        [InverseProperty("FkPmphaseType")]
        public ICollection<PmprojectPhases> PmprojectPhases { get; set; }
    }
}
