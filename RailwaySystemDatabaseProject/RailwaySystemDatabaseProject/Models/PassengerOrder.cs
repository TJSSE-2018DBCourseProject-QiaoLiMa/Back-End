using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Migrations;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations.History;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RailwaySystemDatabaseProject.Models
{
    public enum CompeleteMethodEnum
    {
        InCompleted = 0,
        Completed = 1,
        Canceled = 2,
        Changed = 3
    }

    [Table("PassengerOrder")]
    public class PassengerOrder
    {
        [Key]
        [Column(TypeName = "VARCHAR2")]
        [StringLength(30)]
        public string OrderID { get; set; }

        [Column(TypeName = "VARCHAR2")]
        [StringLength(30)]
        public string AccountID { get; set; }

        [Column(TypeName = "CHAR")]
        [StringLength(18)]
        public string PassengerID { get; set; }

        [Column(TypeName = "VARCHAR2")]
        [StringLength(20)]
        public string TrainNum { get; set; }

        [Column(TypeName = "CHAR")]
        [StringLength(10)]
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

        [Column(TypeName = "int")]
        public CompeleteMethodEnum CompeleteMethod { get; set; }

        [ForeignKey("AccountID")]
        public AccountList AccountList { get; set; }

        [ForeignKey("PassengerID")]
        public Passenger Passenger { get; set; }

        [ForeignKey("StartStation")]
        public Station StationA { get; set; }

        [ForeignKey("EndStation")]
        public Station StationB { get; set; }

        [ForeignKey("TrainNum")]
        public Train Train { get; set; }
    }

    
}
