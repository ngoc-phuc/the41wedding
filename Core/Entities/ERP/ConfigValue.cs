﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Entities.Interfaces;

namespace Entities.ERP
{
    [Table("ConfigValues")]
    public class ConfigValue : IFullEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ConfigValueID")]
        public int Id { get; set; }

        public string AAStatus { get; set; }

        public DateTime? AACreatedDate { get; set; }

        [StringLength(50)] public string AACreatedUser { get; set; }

        public DateTime? AAUpdatedDate { get; set; }

        [StringLength(50)] public string AAUpdatedUser { get; set; }

        public string ConfigKey { get; set; }

        public string ConfigKeyValue { get; set; }

        public string ConfigText { get; set; }

        public string ConfigKeyDesc { get; set; }

        public string ConfigKeyGroup { get; set; }
    }
}