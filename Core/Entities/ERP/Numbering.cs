using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Entities.Interfaces;

namespace Entities.ERP
{
    [Table("Numberings")]
    public class Numbering : IFullEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("NumberingID")]
        public int Id { get; set; }

        public string AAStatus { get; set; }

        public DateTime? AACreatedDate { get; set; }

        [StringLength(50)] public string AACreatedUser { get; set; }

        public DateTime? AAUpdatedDate { get; set; }

        [StringLength(50)] public string AAUpdatedUser { get; set; }

        public string NumberingName { get; set; }

        public string NumberingPrefix { get; set; }

        public int? NumberingLength { get; set; }

        public int? NumberingStart { get; set; }

        public string NumberingDesc { get; set; }
    }
}