using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RailwaySystemDatabaseProject.Models;

namespace RailwaySystemDatabaseProject.Controllers
{
    [Route("PriceList")]
    public class PriceListController : ApiController
    {
        

        [Route("index")]
        [HttpPut]
        public bool ChangePriceTable(Price p)//218韦
        {

            using (var ctx = new OracleDbContext())
            {
                try
                {
                    var pr = ctx.Price.Where(x => x.ValuationID == p.ValuationID).FirstOrDefault();
                     pr.BasePriceOne = p.BasePriceOne;
                     // pr.BasePriceOneUnit = p.BasePriceOneUnit;
                    pr.BasePriceTwo = p.BasePriceTwo;
                    //pr.BasePriceTwoUnit = p.BasePriceTwoUnit;
                    ctx.SaveChanges();

                    //ctx.Train.Add(train);
                    //ctx.SaveChanges();
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            System.Diagnostics.Debug.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }
                
            }
            return true;

        }







        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>
        //[Route("index")]
        //[HttpGet]

        public IHttpActionResult GetPrice()//216
        {
            using (var ctx = new OracleDbContext())
            {
                try
                {


                    var P = ctx.Price.ToList();

                    return Json<List<Price>>(P);

                    //ctx.Train.Add(train);
                    //ctx.SaveChanges();
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            System.Diagnostics.Debug.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }


                    }
                    return Json<string>("errer");
                }

            }
        }

        


    }
}
