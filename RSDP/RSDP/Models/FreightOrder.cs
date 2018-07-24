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
    [Table("FreightOrderTable")]
    public class FreightOrder
    {

        /// <summary>
        ///  [Key]
        /// [Column(TypeName = "VARCHAR2")]
        ///  [Column(TypeName = "int")]
        ///   [Required]
        /// </summary>
        /// 
        [Key]
        [Column(TypeName = "VARCHAR2")]
        public string OrderID { get; set; }

        [Required, Column(TypeName = "VARCHAR2")]
        public string OrderName { get; set; }

        [Required, Column(TypeName = "CHAR")]
        public string SenderName { get; set; }

        [Required, Column(TypeName = "VARCHAR2")]
        public string SenderID { get; set; }

        [Required, Column(TypeName = "VARCHAR2")]
        public string SenderPhoneNumber { get; set; }

        [Required, Column(TypeName = "VARCHAR2")]
        public string ReceiverName { get; set; }

        [Required, Column(TypeName = "VARCHAR2")]
        public string ReceiverPhoneNumber { get; set; }

        [Required, Column(TypeName = "VARCHAR2")]
        public string StartStation { get; set; }

        [Required, Column(TypeName = "VARCHAR2")]
        public string EndStation { get; set; }

        [Required, Column(TypeName = "DATE TIME")]
        public DateTime CreateDate { get; set; }//日期 可能需要操作

        [Column(TypeName = "DATE TIME")]
        public DateTime DueDate { get; set; }

        [Column(TypeName = "VARCHAR2")]
        public string TransferID { get; set; }//外码

        [Column(TypeName = "VARCHAR2")]
        public string PackageID { get; set; }//外码
       
       

        [Column(TypeName = "NUMERIC")]
        public decimal OrderBill { get; set; }

        [Required, Column(TypeName = "INT")]
        public int OrderCapacity { get; set; }

        [Required, Column(TypeName = "INT")]
        public int CarriageNumber { get; set; }

        public virtual Packge Packge { get; set; }
        public virtual Transfer Transfer { get; set; }
    }
}
