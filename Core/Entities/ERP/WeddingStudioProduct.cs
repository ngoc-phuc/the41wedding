using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Entities.Interfaces;

namespace Entities.ERP
{
    [Table("WeddingStudioProducts")]
    public class WeddingStudioProduct : IFullEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("WeddingStudioProductID")]
        public int Id { get; set; }

        public string AAStatus { get; set; }

        public DateTime? AACreatedDate { get; set; }

        [StringLength(50)]
        public string AACreatedUser { get; set; }

        public DateTime? AAUpdatedDate { get; set; }

        [StringLength(50)]
        public string AAUpdatedUser { get; set; }

        public string WeddingStudioProductName { get; set; }

        public string WeddingStudioProductDesc { get; set; }

        public string WeddingStudioProductImages { get; set; }

        public decimal? WeddingStudioProductPrice { get; set; }

        public int? FK_WeddingStudioID { get; set; }

        public int? FK_PriceUnitID { get; set; }

    }
}