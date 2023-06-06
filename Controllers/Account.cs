using Kalinderya_Online_Api_Practice.Helper;
using Microsoft.AspNetCore.Mvc;
using Pet_match.Logic;

namespace Pet_match.Controllers
{
    [Route("api/v1/[controller][action]")]
    [ApiController]
    public class Account : Controller     
    {
        public readonly DbConnection Connection;
        public readonly DbConnector Connector;
        public Account(DbConnection dbConnection, DbConnector dbConnector)
        {
            this.Connection = dbConnection;
            this.Connector = dbConnector;
        }
        [HttpGet]
        public JsonResult Get()
        {

            Accounts acc = new Accounts(Connection, Connector);
            var id = acc.generateUid;
            //apply
            return new JsonResult(acc);
        }
    }
    
}
