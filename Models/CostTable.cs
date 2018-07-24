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
        K = 2
    }

    public enum SeatTypeEnum
    {
        Stand = 0,
        HardSeat = 1,
        SoftSeat = 2,
        SecondClassSeat = 3,
        FirstClassSeat = 4,
        BussinessSeat = 5,
        HardBed = 6,
        SoftBed = 7,
        DongBed = 8
    }

    public enum PassengerTypeEnum
    {
        Normal = 0,
        Student = 1,
        Child = 2,
        DisableSoldier = 3,
        DisablePolice = 4,
        SystemManager = 5
    }

    [Table("CostTableTable")]
    public class CostTable
    {
        [Key, Column(Order = 0, TypeName = "int")]
        public TrainTypeEnum TrainType { get; set; }

        [Key, Column(Order = 1, TypeName = "int")]
        public SeatTypeEnum SeatType { get; set; }

        [Key, Column(Order = 2, TypeName = "int")]
        public PassengerTypeEnum PassengerType { get; set; }

        [Column(TypeName = "number")]
        [Required]
        public decimal CostPerKM { get; set; }
    }
}
