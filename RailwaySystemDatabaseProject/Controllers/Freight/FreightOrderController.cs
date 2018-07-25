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
    [Route("FreightOrder")]
    public class FreightOrderController : ApiController
    {
        /// <summary>
        /// ////////////////////////////////////////////////////////////107韦 已测
        /// </summary>
        
        public class CountType//进入类
        {
            public string QueryType { get; set; }
            public DateTime From { get; set; }
            public DateTime To { get; set; }

        }
        public class DailyCountFreight//用于freightDailyCount的返回
        {
            public string Date { get; set; }
            public int freightOrderNumber { get; set; }
        }
        public class CountFreight//用于freightCount的返回
        {
          
            public int freightOrderNumber { get; set; }
        }

        [Route("FreightOrder/count")]
        [HttpPost]
        public IHttpActionResult GetCountFreight(CountType t)
        {
            System.Diagnostics.Debug.WriteLine(t.QueryType);
            if (t.QueryType == "freightCount")
            {
                using (var ctx = new OracleDbContext())
                {
                  
                   var freightOrderNumber = ctx.FreightOrder.Where(x => x.DueDate >= t.From && x.DueDate <= t.To).Count();//日期比from大比to小
                   var s = new CountFreight();
                    s.freightOrderNumber = freightOrderNumber;

                    var w = Json<CountFreight>(s);
                    return Json<CountFreight>(s);
                }

            }
            else if (t.QueryType == "freightDailyCount")
            {
                var dailyOrderFlow = new List<DailyCountFreight>();//传回去的表
                var sf = new DailyCountFreight();//用于加入LIST
                var temp = t.From;//日期的临时变量用于判断
                while (temp <= t.To)//当时间大于to时结束循环
                {
                    sf.Date = temp.ToString("d");//先把当天日期放到sf的Date中

                    var tomorrow = temp.AddDays(1);
                    using (var ctx = new OracleDbContext())
                    {
                        var count = ctx.FreightOrder.Where(x => x.DueDate >= temp && x.DueDate <= tomorrow).Count();
                        sf.freightOrderNumber = count;//放count
                    }
                    dailyOrderFlow.Add(sf);
                    temp = tomorrow;//日期加一天
                }
                return Json<List<DailyCountFreight>>(dailyOrderFlow);//返回

            }
            else
            {
                return Json<string>("error");
            }
        }







        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////取消货运订单
        /// </summary>
        /// <param name="OId"></param>
        /// <returns></returns>


        [Route("cancle/{orderID}")]
        [HttpPut]
        public bool DeleteOId(string OId)//#223韦
        {
            using (var ctx = new OracleDbContext())
            {

                try
                {
                    FreightOrder F = new FreightOrder() { OrderID = OId };
                    ctx.FreightOrder.Attach(F);
                    ctx.FreightOrder.Remove(F);
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
        /// //////////////////////////////////////////////////////////改订单 224
        /// </summary>
        /// <param name="F"></param>
        /// <returns></returns>

        [Route("cancle/{orderID}")]
        [HttpPut]
        public bool ChangeOrder(FreightOrder F)
        {
            using (var ctx = new OracleDbContext())
            {

                try
                {
                    var FO = ctx.FreightOrder.Where(x => x.OrderID == F.OrderID).FirstOrDefault();

                    FO.SenderName = F.SenderName;
                    FO.SenderPhoneNumber = F.SenderPhoneNumber;
                    FO.SenderID = F.SenderID;
                    FO.ReceiverName = F.ReceiverName;
                    FO.ReceiverPhoneNumber = F.ReceiverPhoneNumber;
                    FO.StartStation = F.StartStation;
                    FO.CarriageNumber = F.CarriageNumber;
                    FO.CreateDate = F.CreateDate;
                    FO.DueDate = F.DueDate;
                    FO.EndStation = F.EndStation;
                    FO.OrderBill = F.OrderBill;
                    FO.State = F.State;
                    FO.PackgeID = F.PackgeID;
                    FO.TrainID = F.TrainID;
                    FO.OrderCapacity = F.OrderCapacity;
                    

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
        
        /////////////////////////////////////////////////////////////////411 某人订单
        /// <summary>
        /// 
        /// </summary>
        public class Query
        {
            public string AccountID { get; set; }
            public int Status { get; set; }
        }
        public class AccountFreight
        {
            public int Status { get; set; }
            public int ResultCount { get; set; }
            public List<FreightOrder> Results { get; set; }
        }

        /*[Route("list")]
        [HttpGet]
        public IHttpActionResult GetFreightOrder(Query query)
        {
            try
            {
                using (var ctx = new OracleDbContext())
                {
                    
                }



                    return Json<List<AccountFreight>>();

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
        */


        ////////////////////////////////////////////////////////////412查询订单   接口问题？
        
        [Route("FreightOrder/index")]
        [HttpGet]
        public IHttpActionResult GeFreight(string ID)
        {

            try
            {
                using (var ctx = new OracleDbContext())
                {
                    
                    var FO = ctx.FreightOrder.Where(x => x.OrderID == ID).FirstOrDefault();
                    
                    var s = Json<FreightOrder>(FO);//测试用
                    return Json<FreightOrder>(FO);
                }
                
              

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
/// 
/*try
                {
                    ctx.Train.Add(train);
                    ctx.SaveChanges();
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
                }*/
