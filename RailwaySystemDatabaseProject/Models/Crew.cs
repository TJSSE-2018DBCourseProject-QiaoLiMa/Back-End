
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

   

    [Table("CrewTable")]
    public class Crew
    {

        [Key]
        [Column(TypeName = "VARCHAR2")]
        [Required]
        [StringLength(20)]
        public string CrewID { get; set; }

      
        
        [Column(TypeName = "int")]
        [Required]
        public int NumberOfPeople { get; set; }

        [Column(TypeName = "VARCHAR2")]
        [Required]
        [StringLength(25)]
        public string ChiefOfCrew { get; set; }

        [Column(TypeName = "VARCHAR2")]
        [Required]
        [StringLength(25)]

        public string ViceDriver { get; set; }
        [Column(TypeName = "VARCHAR2")]
        [Required]
        [StringLength(25)]

        public string MainDriver { get; set; }
         [Column(TypeName = "VARCHAR2")]
        [Required]
        [StringLength(25)]

    }
