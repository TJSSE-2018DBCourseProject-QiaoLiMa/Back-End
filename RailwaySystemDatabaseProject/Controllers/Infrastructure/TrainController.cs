using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RailwaySystemDatabaseProject.Models;

using System.Xml.Linq;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Migrations;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations.History;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailwaySystemDatabaseProject.Controllers
{
    [Route("Train")]
    public class TrainController : ApiController
    {
        [HttpPost]
        public string Create(Train train)
        {
            using (var ctx = new OracleDbContext())
            {

                try
                {
                    ctx.Trains.Add(train);
                    ctx.SaveChanges();
                }
                catch (Exception e)
                {
                    return e.ToString();
                }

            }
            return "OK";
        }
        [Route("Train/Count")]
        public int Count()
        {
            
            using (var ctx = new OracleDbContext())
            { 
                var count=ctx.Trains.Count();
                return count;
            }
           
        }
    }
}
