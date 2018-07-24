
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



    [Table("crewStaffTable")]
    public class CrewStaff
    {

        
        
        [Column(TypeName = "VARCHAR2")]
        [StringLength(20)]
        [Required]
        public string CrewID { get; set; }   //外码

        [Key]
        [Column(TypeName = "VARCHAR2")]
        [StringLength(25)]
        [Required]
        public string StaffID { get; set; }

        
       
    }
}
