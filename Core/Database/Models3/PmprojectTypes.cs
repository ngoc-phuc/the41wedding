using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bys.Database.Models3
{
    [Table("PMProjectTypes")]
    public partial class PmprojectTypes
    {
        public PmprojectTypes()
        {
            PmphaseTypes = new HashSet<PmphaseTypes>();
            Pmprojects = new HashSet<Pmprojects>();
        }

        [Key]
        [Column("PMProjectTypeID")]
        public int PmprojectTypeId { get; set; }
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
        [Column("PMProjectTypeNo")]
        [StringLength(50)]
        public string PmprojectTypeNo { get; set; }
        [Column("PMProjectTypeName")]
        [StringLength(50)]
        public string PmprojectTypeName { get; set; }
        [Column("PMProjectTypeDesc")]
        [StringLength(255)]
        public string PmprojectTypeDesc { get; set; }

        [InverseProperty("FkPmprojectType")]
        public ICollection<PmphaseTypes> PmphaseTypes { get; set; }
        [InverseProperty("FkPmprojectType")]
        public ICollection<Pmprojects> Pmprojects { get; set; }
    }
}
