using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Entities.Interfaces;

namespace Entities.ERP
{
    [Table("StateProvinces")]
    public class StateProvince : IFullEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("StateProvinceID")]
        public int Id { get; set; }

        public string AAStatus { get; set; }

        public DateTime? AACreatedDate { get; set; }

        [StringLength(50)] public string AACreatedUser { get; set; }

        public DateTime? AAUpdatedDate { get; set; }

        [StringLength(50)] public string AAUpdatedUser { get; set; }

        public string StateProvinceNo { get; set; }

        public string StateProvinceName { get; set; }

        public string StateProvinceDesc { get; set; }
    }
}