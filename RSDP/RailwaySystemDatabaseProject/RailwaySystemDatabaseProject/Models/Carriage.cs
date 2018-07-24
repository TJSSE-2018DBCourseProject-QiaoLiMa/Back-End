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
    public enum CarriageFreightTypeEnum
    {
        Freight = 0,
        Passenger =1
    }

    public enum FreightCapacityEnum
    {
        P70 = 0,
        P100 = 1,
        C70 = 2,
        C100 = 3,
    }

    public enum CarriageRunningSituationEnum
    {
        Maintenance = 0,
        Running = 1,
    }

    [Table("CarriageTable")]
        public class Carriage
        {
            [Key]
            [Column(TypeName ="VARCHAR2")]
            public string CarriageID { get; set; }

            [Required,Column (TypeName ="INT")]
            public CarriageFreightTypeEnum CarriageFreightType { get; set; }

            [Column(TypeName ="INT")]
            public FreightCapacityEnum FreightCapacity { get; set; }

            [Column(TypeName ="INT")]
            public int PassengerCapacity { get; set; }

            [Required,Column(TypeName ="INT")]
            public CarriageRunningSituationEnum CarriageRunningSituation { get; set; }

            [Required,Column(TypeName ="INT")]
            public int CarriageCarryingSituation { get; set; }

            [ForeignKey("Train"), Column(TypeName = "VARCHAR2")]
            public string TrainID { get; set; }
            public virtual Train Train { get; set; }

    }
}
