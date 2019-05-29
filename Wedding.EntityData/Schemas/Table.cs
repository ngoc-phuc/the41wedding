using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wedding.EntityData.Schemas
{
    public class Table : CoreTable
    {
        public int? InsertUserCd { get; set; }

        public int? UpdateUserCd { get; set; }
    }

    public class CoreTable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cd { get; set; }

        //[DisplayFormat(DataFormatString = "{0:yyyy年M月d日}", ApplyFormatInEditMode = true)]
        public DateTime? InsertDate { get; set; }

        //[DisplayFormat(DataFormatString = "{0:yyyy年M月d日}", ApplyFormatInEditMode = true)]
        public DateTime? UpdateDate { get; set; }
    }

    public class DeleteFlgTable : Table
    {
        public byte DelFlag { get; set; }
    }
}
