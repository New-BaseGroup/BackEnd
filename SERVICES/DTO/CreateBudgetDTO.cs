using System.ComponentModel.DataAnnotations;
namespace SERVICES.DTO
{
    public record CreateBudgetDTO
    {

        [Required]
        public string BudgetName { get; set; }


        [Required]
        public int TotalAmount { get; init; }
        [Required]
        public DateTime StartDate { get; init; }
        [Required]
        public DateTime EndDate { get; init; }

        public string Description { get; init; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public ICollection<BudgetCategoriesDTO> BudgetCategories{ get; init;}
    }
}
 