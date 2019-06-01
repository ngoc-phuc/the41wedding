using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Entities.Interfaces;

namespace Entities.ERP
{
    [Table("Cummunes")]
    public class Cummune : IFullEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("CummuneID")]
        public int Id { get; set; }

        public string AAStatus { get; set; }

        public DateTime? AACreatedDate { get; set; }

        [StringLength(50)] public string AACreatedUser { get; set; }

        public DateTime? AAUpdatedDate { get; set; }

        [StringLength(50)] public string AAUpdatedUser { get; set; }

        public string CummuneNo { get; set; }

        public string CummuneName { get; set; }

        public string CummuneDesc { get; set; }

        public int? FK_DistrictID { get; set; }
    }
}