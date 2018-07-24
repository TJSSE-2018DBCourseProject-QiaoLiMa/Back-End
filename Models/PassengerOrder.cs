using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Migrations;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations.History;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RailwaySystemDatabaseProject.Models
{
    [Table("PassengerOrder")]
    public class PassengerOrder
    {
        [Key]
        [Column(TypeName = "VARCHAR2")]
        [StringLength(30)]
        public string OrderID { get; set; }

        [ForeignKey("AccountList")]
        [Column(TypeName = "VARCHAR2")]
        [StringLength(30)]
        public string AccountID { get; set; }

        [ForeignKey("Passenger")]
        [Column(TypeName = "VARCHAR2")]
        [StringLength(30)]
        public string PassengerID { get; set; }


        [Column(TypeName = "VARCHAR2")]
        [StringLength(20)]
        public string TrainNum { get; set; }

        [Column(TypeName = "DATE")]
        public string DepartDate { get; set; }


        [Column(TypeName = "VARCHAR2")]
        [StringLength(30)]
        public string StartStation { get; set; }


        [Column(TypeName = "VARCHAR2")]
        [StringLength(30)]
        public string EndStation { get; set; }

        [Column(TypeName = "int")]
        public int CarriageNumber { get; set; }

        [Column(TypeName = "VARCHAR2")]
        [StringLength(10)]
        public string SeatNumber { get; set; }

        [Column(TypeName = "int")]
        public int ChangeableTimes { get; set; }

        [Column(TypeName = "VARCHAR2")]
        [StringLength(30)]
        public string CompeleteMethod { get; set; }

        public AccountList AccountList { get; set; }
        public Passenger Passenger { get; set; }
    }
    
}
