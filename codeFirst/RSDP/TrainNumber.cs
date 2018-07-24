
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Migrations;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations.History;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailwaySystemDatabaseProject.Models
{

public enum TrainRunningDirection
{
    Up = 0,
    Down = 1,
}
[Table("TrainNumberTable")]
    public class TrainNumberTable
    {

        [Key]
        
        [Column(TypeName = "VARCHAR2")]
        [StringLength(20)]
        public string ID { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public TrainTypeEnum trainType { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public TrainRunningSituationEnum trainRunningDirection { get; set; }

    }
}
