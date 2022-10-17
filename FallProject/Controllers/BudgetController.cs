using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SERVICES.DTO;
using SERVICES;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetController : ControllerBase
    {
        private string UserFromToken()
        {
            object value;
            ControllerContext.HttpContext.Items.TryGetValue("Username", out value);

            var username = value.ToString();
            if(username != null)
            return username;
            return "";
        }
        [Authorize]
        [HttpPost("GetBudget")]//you should be able to add
        public IActionResult GetBudget( BudgetParametersDTO budgetParametersDTO)
        {
            try
            {
                //try loging service funktion

                //if service returns true
                var budgets = "temp";
                //service.GetBudgets(budgetParametersDTO); will use the budgetparameters to find budget that match the serach.
                
                    return Ok(new
                    {
                        status = "success",
                        message = budgets
                    });
                

            }
            catch (Exception ex)
            {
                //only activates on real errors
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpGet("{id}", Name = "BudgetById")]
        public IActionResult GetBudgetById(int id)
        {
            try
            {
                var userId = UserService.Instance.GetUserId(UserFromToken());
               var budget = BudgetService.Instance.GetBudgetById(id);
                //IsEmptyObject
                if (budget != null)
                {
                    return Ok(new
                    {
                        status = "success",
                        message = budget
                    });

                }
                else
                    return NotFound(new
                    {
                        status = "failed",
                        message = "not found"
                    });
               

              

            }
            catch (Exception ex)
            {
                //only activates on real errors
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpPost]
        public IActionResult CreateBudget(CreateBudgetDTO budget)
        {
            try
            { //service need to be added.
                var result = BudgetService.Instance.CreateBudget(budget);
               if(result)
                    return Ok(new
                    {
                        status = "success",
                        message = "Budget Saved"
                    });

                else
                    return Ok(new
                    {
                        status = "failure",
                        message = "Budget is not saved"
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
