using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Entities.Interfaces;

namespace Entities.ERP
{
    [Table("WeddingStudioReviews")]
    public class WeddingStudioReview : IFullEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("WeddingStudioReviewID")]
        public int Id { get; set; }

        public string AAStatus { get; set; }

        public DateTime? AACreatedDate { get; set; }

        [StringLength(50)]
        public string AACreatedUser { get; set; }

        public DateTime? AAUpdatedDate { get; set; }

        [StringLength(50)]
        public string AAUpdatedUser { get; set; }

        public int? WeddingStudioReviewRating { get; set; }

        public string WeddingStudioReviewContent { get; set; }

        public string WeddingStudioReviewImages { get; set; }

        public int? FK_UserID { get; set; }

        public int? FK_WeddingStudioID { get; set; }
    }
}