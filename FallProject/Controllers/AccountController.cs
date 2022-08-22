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
                if(loginDto.user == "admin" && loginDto.password == "adminadmin123!") // temporary check will be service function
                return Ok(new
                {
                    status = "success",
                    user = loginDto.user
                });
                //returns a json objekt with status and user property
                //always return same format on the object unless an actual error happens
                else
                    return Ok(new
                    {
                        status = "failure",
                        user = ""
                    });
                // else return Ok("failure");

            }
            catch (Exception ex)
            {
                //only activates on real errors
                return BadRequest(ex.Message);
            }
        }
    }
}
