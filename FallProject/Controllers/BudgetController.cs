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
        public IActionResult GetBudget(GetBudgetDTO GetBudgetDTO)
        {
            try
            {
                var userId = UserService.Instance.GetUserId(UserFromToken());
                var budgets = BudgetService.Instance.GetBudgets(GetBudgetDTO, userId);
                if(GetBudgetDTO.GetAllMetaData)
                {
                    var budgetList = new List<BudgetDTO>();
                    foreach (var b in budgets)
                    {
                        budgetList.Add(BudgetService.Instance.GetBudgetById((int)b.BudgetID));
                    }
                    return Ok(new
                    {
                        status = "success",
                        message = budgetList
                    });
                }
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
        [HttpGet("GetCategory")]
        public IActionResult GetCategory()
        {
            try
            {
              
                var categories = BudgetService.Instance.GetCategorys();
                return Ok(new
                {
                    status = "success",
                    message = categories
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
                //var budget = BudgetService.Instance.GetBudgets(new GetBudgetDTO() { BudgetID = id }).FirstOrDefault();               
                var budget = BudgetService.Instance.GetBudgetById(id);               
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
        public async Task<IActionResult> DeleteBudget(int id)
        {
            try
            {
                // An error occurred while saving the entity changes.
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
