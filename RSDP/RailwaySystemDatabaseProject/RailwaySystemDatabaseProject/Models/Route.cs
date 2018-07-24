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
    [Table("RouteTable")]
        public class Route
        {
            [Key]
            [Column(TypeName ="VARCHAR2")]
            public string RouteID { get; set; }

            [Required,StringLength(50)]
            public string RouteName { get; set; }
        }
}
