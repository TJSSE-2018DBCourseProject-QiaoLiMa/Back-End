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
    [Table("PriceTable")]
    public class Price
    {
        public enum FreightTypeEnum
        {
            Vehicle = 0,//整车
            container = 1,//集装箱
            scattered = 2//零散
        }

        /// <summary>
        ///  [Key]
        /// [Column(TypeName = "VARCHAR2")]
        ///  [Column(TypeName = "int")]
        ///   [Required]
        /// </summary>
        [Key]
        [Column(TypeName = "VARCHAR2")]
        [StringLength(20)]
        public string ValuationID { get; set; }

        [Required, Column(TypeName = "INT")]
        public FreightTypeEnum FreightType { get; set; }//枚举类

        [Column(TypeName = "VARCHAR2")]
        [StringLength(20)]
        public string BasePriceOneUnit { get; set; }

        [Column(TypeName = "number")]
        public decimal BasePriceOne { get; set; }

        [Column(TypeName = "VARCHAR2")]
        [StringLength(20)]
        public string BasePriceTwoUnit { get; set; }

        [Column(TypeName = "number")]
        public decimal BasePriceTwo { get; set; }
       
    }
}
