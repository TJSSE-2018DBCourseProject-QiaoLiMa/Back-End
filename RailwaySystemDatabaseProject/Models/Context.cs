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
using System.Data.Entity.ModelConfiguration;

namespace RailwaySystemDatabaseProject.Models
{

    public class OracleDbContext : DbContext
    {
        public DbSet<Account_Passenger> Account_Passengers { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<AccountList> AccountLists { get; set; }
        public DbSet<CostTable> CostTables { get; set; }
        public DbSet<PassengerOrder> PassengerOrders { get; set; }
        public DbSet<ConstructionAndOverhaulInformation> ConstructionAndOverhaulInformation { get; set; }
        public DbSet<FreightOrder> FreightOrder { get; set; }
        public DbSet<Loco>  Loco { get; set; }
        public DbSet<Packge> Packge { get; set; }
        public DbSet<Price> Price { get; set; }
        public DbSet<Program> Program { get; set; }
        public DbSet<Route> Route { get; set; }
        public DbSet<Station> Station { get; set; }
        public DbSet<Track> Track { get; set; }
        public DbSet<Train> Train { get; set; }
        public DbSet<TrainNumberTable> TrainNumberTable { get; set; }
        public DbSet<Crew> Crew { get; set; }
        public DbSet<Train_TrainNumberTable> Train_TrainNumberTable { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<CrewStaff> CrewStaff { get; set; }
        public DbSet<RealTime> RealTime { get; set; }
        public DbSet<Time> Time { get; set; }
        public DbSet<Transfer> Transfer { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.HasDefaultSchema("C##TESTUSER");
                
        }
        
    }
}