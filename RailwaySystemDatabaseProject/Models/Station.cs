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
    public enum StationRunningSituationEnum
    {
        Maintenance = 0,
        Running = 1,
    }

    public enum StationTypeEnum
    {
        Feight = 0,
        Passenger = 1,
        Combination = 2
    }
    [Table("StationTable")]
        public class Station
        {
            [Key]

            [Column(TypeName = "VARCHAR2")]
            public string StationID { get; set; }

            [Required, Column(TypeName = "int")]
            public StationRunningSituationEnum StationRunningSituation { get; set; }

            [Required, Column(TypeName ="int")]
            public StationTypeEnum StationType { get; set; }

            [Required, Column(TypeName ="VARCHAR2")]
            [StringLength(20)]
            public string StationCity { get; set; }

            [Required, Column(TypeName ="NUMBER")]
            public decimal StationLontitude { get; set; }

            [Required, Column(TypeName = "NUMBER")]
            public decimal StationLatitude { get; set; }

            [Required,Column(TypeName ="int")]
            public int PlatformNum { get; set; }

            [Required, Column(TypeName = "VARCHAR2")]
            public string CAOID { get; set; }
            [ForeignKey("CAOID")]
            public virtual ConstructionAndOverhaulInformation ConstructionAndOverhaulInformation { get; set; }
    }
}
