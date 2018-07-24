
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

namespace RSDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<OracleDbContext>());
            using (var ctx = new OracleDbContext())
            {
                var t = new Train
                {
                    ID = "2",
                    trainType = 0,
                    trainFreightType = 0,
                    trainRunningSituatio = 0

                };
                ctx.Trains.Add(t);
                ctx.SaveChanges();
                Console.Write("Press any key to continue... ");
                Console.ReadLine();
            }
        }
    }
    


    
}
