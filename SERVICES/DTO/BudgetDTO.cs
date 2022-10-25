using System.ComponentModel.DataAnnotations;
namespace SERVICES.DTO
{
    public record BudgetDTO
    {
        public int BudgetID { get; set; }
        [Required]
        public string Name { get; set; }


        [Required]
        public int TotalAmount { get; init; }
        [Required]
        public DateTime StartDate { get; init; }
        [Required]
        public DateTime EndDate { get; init; }

        public string? Description { get; init; }


        [Required]
        public List<BudgetCategoriesDTO> BudgetCategories { get; init;}
    }
}
 