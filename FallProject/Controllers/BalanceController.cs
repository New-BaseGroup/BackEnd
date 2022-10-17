using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SERVICES.DTO;
using SERVICES;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BalanceController : ControllerBase
    {
        private string UserFromToken()
        {
            object value;
            ControllerContext.HttpContext.Items.TryGetValue("Username", out value);

            var username = value.ToString();
            if (username != null)
                return username;
            return "";
        }
        [Authorize]
        [HttpGet]
        public IActionResult GetBalanceChange(int id) // get income or expense based on its id
        {
            try
            {
                // will work once service is aded
                var result = BalanceService.Instance.GetBalanceChange(id);

                //if service returns true
                if (result != null) // temporary check will be service function
                    return Ok(new
                    {
                        status = "success",
                        message = result
                    });
                //returns a json objekt with status and user property
                //always return same format on the object unless an actual error happens
                else
                    return Ok(new
                    {
                        status = "failure",
                        message = "Could not find the balance change"
                    });
                // else return Ok("failure");

            }
            catch (Exception ex)
            {
                //only activates on real errors
                return BadRequest(ex.Message);
            }
        }
        [Authorize]
        [HttpPost]
        public IActionResult AddBalance(BalanceChangeDTO bcDTO)
        {
            try
            {
                // will work once service is aded
                var result = BalanceService.Instance.AddChange(bcDTO);

                //if service returns true
                if (result) // temporary check will be service function
                    return Ok(new
                    {
                        status = "success",
                        message = "Change Saved"
                    });
                //returns a json objekt with status and user property
                //always return same format on the object unless an actual error happens
                else
                    return Ok(new
                    {
                        status = "failure",
                        message = "Balance Change failed"
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
