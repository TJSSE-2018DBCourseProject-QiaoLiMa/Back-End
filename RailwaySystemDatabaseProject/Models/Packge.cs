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
/// <summary>
/// 货运
/// </summary>
namespace RailwaySystemDatabaseProject.Models
{
    [Table("PackgeTable")]
    public class Packge
    {
        public enum PackageTypeEnum
        {
            Vehicle = 0,
            container = 1,
            scattered = 2
        }

        /// <summary>
        ///  [Key]
        /// [Column(TypeName = "VARCHAR2")]
        ///  [Column(TypeName = "int")]
        ///   [Required]
        /// </summary>
        /// 
        [Key]
        [Column(TypeName = "VARCHAR2")]
        [StringLength(20)]
        public string PackageID { get; set; }

        [Required, Column(TypeName = "VARCHAR2")]
        [StringLength(20)]
        public string PackageName { get; set; }

        [Required, Column(TypeName = "int")]
        public PackageTypeEnum PackageType { get; set; }//枚举类

        [Required, Column(TypeName = "number")]
        public decimal Weight { get; set; }

        [Column(TypeName = "INT")]
        public int BoxCount { get; set; }

        [Column(TypeName = "INT")]
        public int ContainerID { get; set; }//外码后面总和再改！！！
    }
}
