
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

public enum TrainTypeEnum
{
    G = 0,
    D = 1,
    K = 2,
}

public enum TrainFreightTypeEnum
{
    Freight = 0,
    Passenger = 1,
}
public enum TrainRunningSituationEnum
{
    Maintenance = 0,
    Running = 1,
}
[Table("TrainTable")]
    public class Train
    {

        [Key]
        
        [Column(TypeName = "VARCHAR2")]
        public string TrainID { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public TrainTypeEnum TrainType { get; set; }

        [Column(TypeName = "int")]
        public TrainFreightTypeEnum TrainFreightType { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public TrainRunningSituationEnum TrainRunningSituatio { get; set; }

        public virtual ICollection<Carriage> Carriage { get; set; }

    }
}
