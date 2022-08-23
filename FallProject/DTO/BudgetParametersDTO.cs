using System.ComponentModel.DataAnnotations;
namespace API.DTO
{
    public class BudgetParametersDTO
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? CustomeName { get; set; }
        public string? user { get; set; }
        public int? BudgetId { get; set; }




    }
}
 