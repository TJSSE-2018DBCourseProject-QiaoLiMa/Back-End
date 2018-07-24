
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


[Table("Train_TrainNumberTable")]
    public class Train_TrainNumberTable
    {


        [Key]
        [Required]
        [Column(TypeName = "VARCHAR2")]
        [StringLength(10)]
        public string trainNumber { get; set; }

        [Key]
        [Column(TypeName = "VARCHAR2")]
        [Required]
        [StringLength(10)]
        public string physicalTrainNumber { get; set; }


        [Column(TypeName = "DATE")]
        [Required]
        public string DATE { get; set; }


        [Column(TypeName = "VARCHAR2")]
        [Required]
        [StringLength(10)]
        public string trainHeadNumber { get; set; }

}
}
