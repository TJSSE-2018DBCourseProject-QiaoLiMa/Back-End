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
    [Table("PassengerTable")]
    public class Passenger
    {
        [Key]
        [Column(TypeName = "CHAR")]
        [StringLength(18)]
        public string PassengerID { get; set; }

        [Column(TypeName = "VARCHAR2")]
        [Required]
        [StringLength(20)]
        public string PassengerName { get; set; }

        [Column(TypeName = "VARCHAR2")]
        [StringLength(20)]
        public string ConInfo { get; set; }
        
        //[ForeignKey("CostTable")]
        [Column(TypeName = "int")]
        [Required]
        public PassengerTypeEnum PassengerType { get; set; }

        //public CostTable CostTable { get; set; }
    }
   
}
