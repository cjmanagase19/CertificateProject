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
        Account acc;
        public Account()
        {
            this.acc = new Account();

        }
        [HttpPost]
        public JsonResult RegisterPet(Pet pet)
        {
            acc.RegisterPet(pet);
            return new JsonResult(new
            {
                pet_id = pet.petUid,
                pet_name = pet.petName,
            });
        }
        [HttpPost]
        public JsonResult RegisterUser(User user)
        {
            acc.RegisterUser(user);
            return new JsonResult(new
            {
                resCode = 200,
                first_name = user.firstName,
                last_name = user.lastName,
                age = user.age,
                address = user.address,
            });
        }
        [HttpPost]
        public JsonResult Register(Login login)
        {
            this.acc.Register(login); ;
            //apply
            return new JsonResult(new { 
                userName = login.userName,
                password = login.password
            });
        }
    }
    
}
