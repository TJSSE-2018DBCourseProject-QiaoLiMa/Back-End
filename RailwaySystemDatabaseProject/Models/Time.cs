
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

    public enum Condition
    {
        OnRoad = 1,
        Arrived = 2,
        Error = 3,
    }
    
    [Table("TimeTable")]
    public class Time
    {
        [Required]
        [Column(TypeName = "DATE")]
        public string Date { get; set; }


        [Key]
        [Required]
        [Column(TypeName = "VARCHAR2")]
        [StringLength(10)]
        public string TrainNumber { get; set; }      //外码

        [Column(TypeName = "int")]
        [Required]
        public int  StationOrder { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "DATE")]
        public string DepartuerDate { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR2")]
        [StringLength(5)]
        public string StationID { get; set; }      //外码



        [Column(TypeName = "int")]
        [Required]
        public int PlatformNum { get; set; }

        [Column(TypeName = "TIME")]
        public string ArriveTime { get; set; }

        [Column(TypeName = "TIME")]
        public string LeaveTime { get; set; }

        [Column(TypeName = "TIME")]
        public string Duration { get; set; }

      
        [Column(TypeName = "int")]
        [Required]
        public Condition condition { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public int RemainingSeatsNumber { get; set; }


        [Required]
        [Column(TypeName = "VARCHAR2")]
        [StringLength(20)]
        public string CrewID { get; set; }      //外码
        
    }
}
