using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Entities.Interfaces;

namespace Entities.ERP
{
    [Table("WeddingStudioProductReviews")]
    public class WeddingStudioProductReview : IFullEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("WeddingStudioProductReviewID")]
        public int Id { get; set; }

        public string AAStatus { get; set; }

        public DateTime? AACreatedDate { get; set; }

        [StringLength(50)] public string AACreatedUser { get; set; }

        public DateTime? AAUpdatedDate { get; set; }

        [StringLength(50)] public string AAUpdatedUser { get; set; }

        public int WeddingStudioProductReviewRating { get; set; }

        public string WeddingStudioProductReviewContent { get; set; }

        public string WeddingStudioProductReviewImages { get; set; }

        public int? FK_UserID { get; set; }

        public int? FK_WeddingStudioProductID { get; set; }
    }
}