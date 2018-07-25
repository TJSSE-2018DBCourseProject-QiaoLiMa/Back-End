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
    [Route("Carriage")]
    public class CarriageController : ApiController
    {
        public class CS
        {
            public string ID { get; set; }
            public CarriageRunningSituationEnum CarriageRunningSituation { get; set; }

        }

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>
        [Route("Carriage/status")]
        [HttpPut]
        public bool ChangeStatus(CS cS)
        {
            using (var ctx = new OracleDbContext())
            {
               
                try
                {

                    var carr = ctx.Carriage.Where(x => x.CarriageID == cS.ID).FirstOrDefault();

                    carr.CarriageRunningSituation = cS.CarriageRunningSituation;

                    ctx.SaveChanges();
                    return true;
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
                    return false;
                }

            }



        }
    
        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>
      

        //[HttpGet(ID)]
        [HttpPut]
        public bool ChangeCarriage(Carriage c)
        {
            using (var ctx = new OracleDbContext())
            {
               
                try
                {
                    var carr = ctx.Carriage.Where(x => x.CarriageID == c.CarriageID).FirstOrDefault();

                    carr.CarriageFreightType = c.CarriageFreightType;
                    carr.FreightCapacity = c.FreightCapacity;
                    carr.PassengerCapacity = c.PassengerCapacity;
                    carr.CarriageRunningSituation = c.CarriageRunningSituation;
                    carr.TrainID = c.TrainID;
                    carr.CarriageCarryingSituation = c.CarriageCarryingSituation;

                    ctx.SaveChanges();

                    return true;
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
                    return false;
                }


            }
        }

    }


}

/// <summary>
///   [HttpGet]
///public IHttpActionResult GetOrder()
///{
///    var lstRes = new List<ORDER>();

//实际项目中，通过后台取到集合赋值给lstRes变量。这里只是测试。
///    lstRes.Add(new ORDER() { ID = "aaaa", NO = "111", NAME = "111", DESC = "1111" });
///    lstRes.Add(new ORDER() { ID = "bbbb", NO = "222", NAME = "222", DESC = "2222" });

///    return Json<List<ORDER>>(lstRes);
///}

/// </summary>