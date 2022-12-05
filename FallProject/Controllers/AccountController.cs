using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SERVICES.DTO;
using SERVICES;
using API.Authentication;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly IConfiguration _configuration;
        public AccountController(ITokenService tokenService, IConfiguration config)
        {
            _tokenService = tokenService;
            _configuration = config;
        }

        private string UserFromToken()
        {
            object value;
            ControllerContext.HttpContext.Items.TryGetValue("Username", out value);

            var username = value.ToString();
            if (username != null)
                return username;
            return "";
        }
        [AllowAnonymous] //will allow anyone to use this endpoint so that u dont have to be loged in to log in ;)
        [HttpPost("login")]
        public IActionResult Login(LoginDTO loginDTO)
        {

            //try loging service funktion
            try
            {

            
                //if service returns true
                if (UserService.Instance.Login(loginDTO))
                {
                    var generatedToken = _tokenService.BuildToken(_configuration["Jwt:Key"].ToString(), _configuration["Jwt:Issuer"].ToString(), loginDTO.User);
                    return Ok(new
                    {
                        status = "success",
                        message = loginDTO.User,
                        token = generatedToken
                    });
                }
               
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
                return BadRequest(ex);
            }
        }

        [AllowAnonymous] //will allow anyone to use this endpoint so that u dont have to be loged in to log in ;)
        [HttpPost("register")]
        public IActionResult Register(RegisterUserDTO registerUserDTO)
        {
            //try
            //{
                if (UserService.Instance.RegisterNewAccount(registerUserDTO)) // temporary check if user is registered already  will  be a service function
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

            //}
            //catch (Exception ex)
            //{
            //    //only activates on real errors
            //    return BadRequest(ex.Message);
            //}
        }

        [AllowAnonymous]
        [HttpPost("recover")]
        public IActionResult Recover(NewPasswordDTO newPasswordDTO)
        {
            try
            {  //recovery function not implemented in service yet.
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
        [Authorize]
        [HttpGet("Widgets")]
        public IActionResult GetWidgets()
        {
            try
            {
                var userID = UserService.Instance.GetUserId(UserFromToken());
                var widgets = UserService.Instance.getAllWidgets(userID);
                return Ok(new
                {
                    status = "success",
                    message = widgets
                });


            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [Authorize]
        [HttpPost("Widgets")]
        public IActionResult SaveWidgets(List<WidgetDTO> widgets)
        {
            try
            {
                var userID = UserService.Instance.GetUserId(UserFromToken());
                var result = UserService.Instance.SaveWidgets(widgets, userID);
                if (result)
                {
                    return Ok(new
                    {
                        status = "success",
                        message = "Widgets Saved"
                    });
                } else
                {
                    return Ok(new
                    {
                        status = "success",
                        message = "Widgets not saved"
                    });
                }



            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
