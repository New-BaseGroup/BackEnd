using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using API.DTO;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BalanceController : ControllerBase
    {
        [AllowAnonymous]  //change to autorized once that is implemented
        [HttpGet]
        public IActionResult GetBalanceChange(int id)
        {
            try
            {
                // will work once service is aded
                //var result = balanceService.Instance.GetBalanceChange(id);
                BalanceChangeDTO result = null; 

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
        [AllowAnonymous]  //change to autorized once that is implemented
        [HttpPost]
        public IActionResult AddBalance(BalanceChangeDTO bcDTO)
        {
            try
            {
                // will work once service is aded
                //var result = balanceService.Instance.BalanceChange(bcDTO.BudgetCategoryID, bcDTO.Amount, bcDTO.Title, bcDTO.Description, bcDTO.Date);
                var result = true; 

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
        [AllowAnonymous]  //change to autorized once that is implemented
        [HttpDelete]
        public IActionResult Login(int id)
        {
            try
            {
                // will work once service is aded
                //var result = balanceService.Instance.RemoveBalanceChange(id);
                var result = true;

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
