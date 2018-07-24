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
    public enum ComponentTypeEnum
    {
        loco = 0,
        carriage =1,
        station =2,
        track =3
    }

    [Table("ConstructionAndOverhaulInformationTable")]
        public class ConstructionAndOverhaulInformation
        {
            [Key]
            [Column(TypeName ="VARCHAR2")]
            public string CAOID { get; set; }

            [Required,Column(TypeName ="int")]
            public ComponentTypeEnum ComponentType { get; set; }

            [Required,Column(TypeName ="VARCHAR2")]
            [MaxLength(20)]
            public String TimeIntoService { get; set; }

            //时间间隔。类型存疑。。
            [Required,Column(TypeName ="VARCHAR2")]
            [MaxLength(20)]
            public String OverhaulCycle { get; set; }

            [Column(TypeName ="VARCHAR2")]
            [MaxLength(20)]
            public String LastOverhaulDate { get; set; }

            [Column(TypeName = "VARCHAR2")]
            [MaxLength(200)]
            public String LastOverhaulResult { get; set; }

            [Required,Column(TypeName ="VARCHAR2")]
            [MaxLength(20)]
            public String ConstructionDate { get; set; }

            [Required,Column(TypeName ="VARCHAR2")]
            [MaxLength(20)]
            public String ConstructionUnit { get; set; }

            [Required,Column(TypeName ="VARCHAR2")]
            [MaxLength(20)]
            public String ReliableAge { get; set; }

        }
}
