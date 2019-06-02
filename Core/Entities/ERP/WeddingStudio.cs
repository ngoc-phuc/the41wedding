using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Entities.Interfaces;

namespace Entities.ERP
{
    [Table("WeddingStudios")]
    public class WeddingStudio : IFullEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("WeddingStudioID")]
        public int Id { get; set; }

        public string AAStatus { get; set; }

        public DateTime? AACreatedDate { get; set; }

        [StringLength(50)]
        public string AACreatedUser { get; set; }

        public DateTime? AAUpdatedDate { get; set; }

        [StringLength(50)]
        public string AAUpdatedUser { get; set; }

        public string WeddingStudioName { get; set; }

        public string WeddingStudioAddress { get; set; }

        public string WeddingStudioPhone { get; set; }

        public string WeddingStudioEmail { get; set; }

        public string WeddingStudioWebsite { get; set; }

        public string WeddingStudioRepresentativeName { get; set; }

        public string WeddingStudioRepresentativePhone { get; set; }

        public string WeddingStudioRepresentativeEmail { get; set; }

        public string WeddingStudioRepresentativeIntro { get; set; }

        public string WeddingStudioRepresentativeIntroImages { get; set; }

        public string WeddingStudioCoverImage { get; set; }

        public string WeddingStudioAvatar { get; set; }

        public decimal? WeddingStudioAveragePrice { get; set; }

        public int? FK_WeddingStudioGroupID { get; set; }

        public int? FK_StateProvinceID { get; set; }

        public int? FK_DistrictID { get; set; }

        public int? FK_CommuneID { get; set; }

        [ForeignKey("FK_WeddingStudioGroupID")]
        public virtual WeddingStudioGroup WeddingStudioGroup { get; set; }

        [InverseProperty("WeddingStudio")] public virtual ICollection<WeddingStudioReview> WeddingStudioReviews { get; set; }

        [InverseProperty("WeddingStudio")] public virtual ICollection<WeddingStudioProduct> WeddingStudioProducts { get; set; }
    }
}