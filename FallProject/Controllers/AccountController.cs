using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using API.DTO;
using SERVICES;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [AllowAnonymous] //will allow anyone to use this endpoint so that u dont have to be loged in to log in ;)
        [HttpPost("login")]
        public IActionResult Login(LoginDTO loginDTO)
        {
            try
            {
                //try loging service funktion

                //if service returns true
                if (UserService.Instance.Login(loginDTO.User, loginDTO.Password)) // temporary check will be service function
                    return Ok(new
                    {
                        status = "success",
                        message = loginDTO.User
                    });
                //returns a json objekt with status and user property
                //always return same format on the object unless an actual error happens
                else
                    return Ok(new
                    {
                        status = "failure",
                        message = "wrong password or username"
                    });
                // else return Ok("failure");

            }
            catch (Exception ex)
            {
                //only activates on real errors
                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous] //will allow anyone to use this endpoint so that u dont have to be loged in to log in ;)
        [HttpPost("register")]
        public IActionResult Register(RegisterUserDTO registerUserDTO)
        {
            try
            {
                if (UserService.Instance.RegisterNewAccount(registerUserDTO.User, registerUserDTO.Password, registerUserDTO.Email)) // temporary check if user is registered already  will  be a service function
                    return Ok(new
                    {
                        status = "success",
                        message = registerUserDTO.User
                    });

                else
                    return Ok(new
                    {
                        status = "failure",
                        message = "Username or email is already used"
                    });

            }
            catch (Exception ex)
            {
                //only activates on real errors
                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpPost("recover")]
        public IActionResult Recover(NewPasswordDTO newPasswordDTO)
        {
            try
            {
                if(newPasswordDTO.Password != "hej") // temporary check if user is registered already  will  be a service function
                    return Ok(new
                    {
                        status = "success",
                        message = "New password saved"
                    });

                else
                    return Ok(new
                    {
                        status = "failure",
                        message = "Password is not secure"
                    });

            }
            catch (Exception ex)
            {
                //only activates on real errors
                return BadRequest(ex.Message);
            }
        }
    }
}
