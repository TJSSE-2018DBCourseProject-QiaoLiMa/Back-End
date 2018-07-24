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
    public enum LoadTypeEnum
    {
        G = 0,
        D = 1,
        K = 2,
    }

    public enum TrackRunningSituationEnum
    {
        Maintenance = 0,
        Running = 1,
    }
    [Table("TrackTable")]
    public class Track
    {
        [Key]
        [Column(TypeName = "VARCHAR2")]
        public string TrackID { get; set; }

        [Required,Column(TypeName ="INT")]
        public LoadTypeEnum LoadType { get; set; }

        [Required,Column(TypeName ="NUMBER")]
        public decimal SpeedLimitation { get; set; }

        [Required,Column(TypeName ="INT")]
        public TrackRunningSituationEnum TrackRunningSituation { get; set; }

        [Required,Column(TypeName ="NUMBER")]
        public decimal TrackLength { get; set; }

        //有问题待解决
        [Required, Column(TypeName = "VARCHAR2")]
        public string StationAID { get; set; }
        [ForeignKey("StationAID")]
        public virtual Station StaionA { get; set; }

        [Required, Column(TypeName = "VARCHAR2")]
        public string StationBID { get; set; }
        [ForeignKey("StationBID")]
        public virtual Station StationB { get; set; }

        
        [Required, Column(TypeName = "VARCHAR2")]
        public string RouteID { get; set; }
        [ForeignKey("RouteID")]
        public virtual Route Route { get; set; }

        [Required, Column(TypeName = "VARCHAR2")]
        public string CAOID { get; set; }
        [ForeignKey("CAOID")]
        public virtual ConstructionAndOverhaulInformation ConstructionAndOverhaulInformation { get; set; }
    }
}
