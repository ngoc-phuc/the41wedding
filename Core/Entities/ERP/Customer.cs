using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Entities.Interfaces;

namespace Entities.ERP
{
    [Table("Customers")]
    public class Customer : IFullEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("CustomerID")]
        public int Id { get; set; }

        public string AAStatus { get; set; }

        public DateTime? AACreatedDate { get; set; }

        [StringLength(50)] public string AACreatedUser { get; set; }

        public DateTime? AAUpdatedDate { get; set; }

        [StringLength(50)] public string AAUpdatedUser { get; set; }

        public string CustomerNo { get; set; }

        public string CustomerName { get; set; }

        public string CustomerFullName { get; set; }

        public bool? CustomerGender { get; set; }

        public string CustomerPhone1 { get; set; }

        public string CustomerPhone2 { get; set; }

        public string CustomerEmail { get; set; }

        public string CustomerAddress { get; set; }

        public string CustomerAvatar { get; set; }

        public int? FK_StateProvinceID { get; set; }

        public int? FK_DistrictID { get; set; }

        public int? FK_CommuneID { get; set; }
    }
}