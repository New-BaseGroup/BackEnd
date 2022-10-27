using System.ComponentModel.DataAnnotations;
namespace SERVICES.DTO
{
    public class GetBudgetDTO
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? CustomeName { get; set; }
        public int? BudgetID { get; set; }
        public int? TotalAmount { get; set; }
        public string? Description { get; set; }

        public bool GetAllMetaData { get; set; }
        //public int UserID { get; set; }
    }
}
 