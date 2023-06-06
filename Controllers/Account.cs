using Kalinderya_Online_Api_Practice.Helper;
using Microsoft.AspNetCore.Mvc;
using Pet_match.Logic;
using Pet_match.Model;

namespace Pet_match.Controllers
{
    [Route("api/v1/[controller][action]")]
    [ApiController]
    public class Account : Controller     
    {
        public Account()
        {

        }
        [HttpPost]
        public JsonResult Register(Login login)
        {

            Accounts acc = new Accounts();
            Login loginOutput = acc.RegisterLogin(login); ;
            //apply
            return new JsonResult(new { 
                id=loginOutput.Guid,
                userName = loginOutput.userName,
                password = loginOutput.password
            });
        }
    }
    
}
