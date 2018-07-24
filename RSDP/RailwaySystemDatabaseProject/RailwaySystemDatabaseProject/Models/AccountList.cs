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
    [Table("AccountListTable")]
    public class AccountList
    {
        [Key]
        [Column(TypeName = "VARCHAR2")]
        [StringLength(30)]
        public string AccountID { get; set; }

        [Column(TypeName = "VARCHAR2")]
        [Required]
        [StringLength(30)]
        public string AccountPassword { get; set; }
    }
}
