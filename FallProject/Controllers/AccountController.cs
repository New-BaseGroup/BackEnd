using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using API.DTO;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [AllowAnonymous] //will allow anyone to use this endpoint so that u dont have to be loged in to log in ;)
        [HttpPost("login")]
        public IActionResult Login(LoginDTO loginDto)
        {
            try 
            {
                //try loging service funktion

                //if service returns true
                return Ok("login success");
                // else return Ok("login failed");
                
            }
            catch (Exception ex)
            {
                //only activates on real errors
                return BadRequest(ex.Message);
            }
        }
    }
}
