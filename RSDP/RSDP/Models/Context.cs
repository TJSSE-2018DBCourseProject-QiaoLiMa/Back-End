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
namespace RSDP.Models
{

    public class OracleDbContext : DbContext
    {
        public DbSet<Train> Trains { get; set; }


        /// <summary>
        /// 货运
        /// </summary>
        public DbSet<FreightOrder> FreightOrder { get; set; }

        public DbSet<Packge> Packge { get; set; }

        public DbSet<Price> Price { get; set; }

        public DbSet<Transfer> Transfer { get; set; }
        /// <summary>
        /// 货运
        /// </summary>





        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /// <summary>
            /// 货运
            /// </summary>
            modelBuilder.Entity<Price>().Property(t => t.BasePriceOne)
                                          .HasColumnName("BasePriceOne")
                                          .HasPrecision(5, 2);

            modelBuilder.Entity<Price>().Property(t => t.BasePriceTwo)
                                          .HasColumnName("BasePriceTwo")
                                          .HasPrecision(6, 2);



            /// <summary>
            /// 货运
            /// </summary>

            modelBuilder.HasDefaultSchema("C##TESTUSER");

        }
    }
}