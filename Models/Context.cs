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

    public class OracleDbContext : DbContext
    {
        public DbSet<Train> Trains { get; set; }
        public DbSet<Account_Passenger> Account_Passengers { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<AccountList> AccountLists { get; set; }
        public DbSet<CostTable> CostTables { get; set; }
        public DbSet<FreightOrder> FreightOrder { get; set; }

        public DbSet<Packge> Packge { get; set; }

        public DbSet<Price> Price { get; set; }

        public DbSet<Transfer> Transfer { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.HasDefaultSchema("C##TESTUSER");
            //modelBuilder.Entity<Passenger>()
            modelBuilder.Entity<Price>().Property(t => t.BasePriceOne)
                                          .HasColumnName("BasePriceOne")
                                          .HasPrecision(5, 2);

            modelBuilder.Entity<Price>().Property(t => t.BasePriceTwo)
                                          .HasColumnName("BasePriceTwo")
                                          .HasPrecision(6, 2);


        }
    }
}