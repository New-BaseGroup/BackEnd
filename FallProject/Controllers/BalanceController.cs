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
        public IActionResult GetBalanceChange(int id) 
        {
            try
            {
                var result = BalanceService.Instance.GetBalanceChange(id);
                if (result != null) 
                    return Ok(new
                    {
                        status = "success",
                        message = result
                    });
                else
                    return Ok(new
                    {
                        status = "failure",
                        message = "Could not find the balance change"
                    });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [Authorize]
        [HttpPost]
        public IActionResult AddBalance(BalanceChangeDTO bcDTO)
        {
            try
            {
                var result = BalanceService.Instance.AddChange(bcDTO);
                if (result) 
                    return Ok(new
                    {
                        status = "success",
                        message = "Change Saved"
                    });              
                else
                    return Ok(new
                    {
                        status = "failure",
                        message = "Balance Change failed"
                    });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [Authorize]
        [HttpDelete]
        public IActionResult DeleteBalance(int id)
        {
            try
            {
                var result = BalanceService.Instance.DeleteChange(id);

                if (result) 
                    return Ok(new
                    {
                        status = "success",
                        message = "Change Deleted"
                    });
                else
                    return Ok(new
                    {
                        status = "failure",
                        message = "Balance Change failed"
                    });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [Authorize]
        [HttpPut]
        public IActionResult UpdateChange(UpdateChangeDTO changeDTO)
        {
            try
            {
                var result = BalanceService.Instance.UpdateChange(changeDTO);
                if (result)
                    return Ok(new
                    {
                        status = "success",
                        message = "Change Updated"
                    });
                else
                    return Ok(new
                    {
                        status = "failure",
                        message = "Balance Change failed"
                    });
            }
            catch (Exception ez)
            {
                return BadRequest(ez.Message);
            }
        }
    }
}
