using System;
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
namespace RSDP.Models
{
    [Table("TransferTable")]
    public class Transfer
    {
        /// <summary>
        ///  [Key]
        /// [Column(TypeName = "VARCHAR2")]
        ///  [Column(TypeName = "int")]
        ///   [Required]
        /// </summary>

        [Key]
        [Column(Order=0,TypeName = "VARCHAR2")]
        public string OrderID { get; set; }
        [Key]
        [Column(Order = 1, TypeName = "VARCHAR2")]
        public string PackageID { get; set; }
        [Key]
        [Column(Order = 2, TypeName = "VARCHAR2")]
        public string TrainID { get; set; }
        [Key]
        [Column(Order = 3,TypeName = "VARCHAR2")]
        public string TransferID { get; set; }

        [Required, Column(TypeName = "DATE TIME")]
        public DateTime StartTime { get; set; }

        [Column(TypeName = "DATE TIME")]
        public DateTime EndTime { get; set; }

        [Column(TypeName = "VARCHAR2")]
        public string State { get; set; }
    }
}
