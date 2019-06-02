using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Entities.Interfaces;

namespace Entities.ERP
{
    [Table("WeddingStudioGroups")]
    public class WeddingStudioGroup : IFullEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("WeddingStudioGroupID")]
        public int Id { get; set; }

        public string AAStatus { get; set; }

        public DateTime? AACreatedDate { get; set; }

        [StringLength(50)]
        public string AACreatedUser { get; set; }

        public DateTime? AAUpdatedDate { get; set; }

        [StringLength(50)]
        public string AAUpdatedUser { get; set; }

        public string WeddingStudioGroupNo { get; set; }

        public string WeddingStudioGroupName { get; set; }

        public string WeddingStudioGroupDesc { get; set; }

        [InverseProperty("WeddingStudioGroup")] public virtual ICollection<WeddingStudio> WeddingStudios { get; set; }
    }
}