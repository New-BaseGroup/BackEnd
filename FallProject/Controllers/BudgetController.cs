using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using API.DTO;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetController : ControllerBase
    {
        [AllowAnonymous] //change to autorized when autentication is implemented
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

        [AllowAnonymous] //will allow anyone to use this endpoint so that u dont have to be loged in to log in ;)
        [HttpGet("{id}", Name = "BudgetById")]
        public IActionResult GetBudgetById(int id)
        {
            try
            {
                var budget = "";
                //var budget = "temp: service.GetBudgetById(id);";
                //IsEmptyObject
                if (budget == "")
                {
                    return NotFound(new
                    {
                        status = "failed",
                        message = "not found"
                    });
                
                }
                else 

                    return Ok(new
                    {
                        status = "success",
                        message = budget
                    });

              

            }
            catch (Exception ex)
            {
                //only activates on real errors
                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult CreateBudget(CreateBudgetDTO budget)
        {
            try
            { //service need to be added.
                //BudgetSErvice.Instance.AddBudget(budget.BudgetName , budget.TotalAmount , budget.StartDate, budget.EndDate , budget.Description , budget,UserId , budget.BudgetCategories);
               if(budget.BudgetName != "adam")
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
