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
    public enum LocoTypeEnum
    {
        G = 0,
        D = 1,
        K = 2,
        N = 3
    }

    public enum LocoRunningSituationEnum
    {
        Maintenance = 0,
        Running = 1
    }

    [Table("LocoTable")]
        public class Loco
        {
            [Key]
            [Column(TypeName ="VARCHAR2")]
            public string LocoID { get; set; }
            
            [Required,Column(TypeName ="INT")]
            public LocoTypeEnum LocoType { get; set; }

            [Required,Column(TypeName="NUMBER")]
            public decimal FuelSituation { get; set; }

            [Required,Column(TypeName ="INT")]
            public LocoRunningSituationEnum LocoRunningSituation { get; set; }

            [ForeignKey("Train")]
            [Column(TypeName ="VARCHAR2")]
            public string TrainID { get; set; }
            public virtual Train Train { get; set; }
            
            [Required, Column(TypeName = "VARCHAR2")]
            public string CAOID { get; set; }
            [ForeignKey("CAOID")]
            public virtual ConstructionAndOverhaulInformation ConstructionAndOverhaulInformation { get; set; }
            
    }
}
