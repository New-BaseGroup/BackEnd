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
            if (username != null)
                return username;
            return "";
        }
        [Authorize]
        [HttpPost("GetBudget")]
        public IActionResult GetBudget(GetBudgetDTO budgetParametersDTO)
        {
            try
            {
                var budgets = BudgetService.Instance.GetBudgets(budgetParametersDTO);
                return Ok(new
                {
                    status = "success",
                    message = budgets
                });


            }
            catch (Exception ex)
            {
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
                var budget = BudgetService.Instance.GetBudgets(new GetBudgetDTO() { BudgetID = id }).FirstOrDefault();
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
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpPost]
        public IActionResult CreateBudget(CreateBudgetDTO budget)
        {
            try
            {
                var result = BudgetService.Instance.CreateBudget(budget);
                if (result)
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
                return BadRequest(ex.Message);
            }
        }
        [Authorize]
        [HttpDelete]
        public IActionResult DeleteBudget(int id)
        {
            try
            {
                var result = BudgetService.Instance.DeleteBudget(id);

                if (result)
                    return Ok(new
                    {
                        status = "success",
                        message = "Budget Deleted"
                    });
                else
                    return Ok(new
                    {
                        status = "failure",
                        message = "Budget failed"
                    });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [Authorize]
        [HttpPut]
        public IActionResult UpdateBudget(GetBudgetDTO Budget)
        {
            try
            {
                var result = BudgetService.Instance.UpdateBudget(Budget);
                if (result)
                    return Ok(new
                    {
                        status = "success",
                        message = "Budget Updated"
                    });
                else
                    return Ok(new
                    {
                        status = "failure",
                        message = "Budget failed"
                    });
            }
            catch (Exception ez)
            {
                return BadRequest(ez.Message);
            }
        }
    }

}
