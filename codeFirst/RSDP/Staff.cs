
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

    public enum Gender
    {
        Female = 0,
        Male = 1,
    }

    public enum TypeOfWork //待定！！
    {
        Saller = 1,
        Teller = 2,
        SecurityInspector = 3,
        TrainConductor = 4,
    }

    public enum Position //待定！！
    {
        Low = 1,
        Mid = 2,
        High = 3,
        Super = 4,
    }

    [Table("StaffTable")]
    public class Staff
    {

        [Key]
        
        [Column(TypeName = "VARCHAR2")]
        [Required]
        [StringLength(20)]
        public string ID { get; set; }

        [Column(TypeName = "VARCHAR2")]
        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        
        [Column(TypeName = "int")]
        [Required]
        public Gender gender { get; set; }


        [Column(TypeName = "VARCHAR2")]
        [StringLength(28)]
        [Required]
        public string IDCardNumber { get; set; }


        [Column(TypeName = "int")]
        [Required]
        public TypeOfWork  typeOfWork { get; set; }


        [Column(TypeName = "int")]
        [Required]
        public Position position { get; set; }
    }
}
