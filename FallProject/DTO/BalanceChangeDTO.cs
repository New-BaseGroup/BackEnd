using System.ComponentModel.DataAnnotations;
namespace API.DTO
{
    public record BalanceChangeDTO
    {

        [Required]
        public int BudgetCategoryID { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public DateTime Date { get; init; }

        [Required]
        public string Title { get; set; }
        public string? Description { get; init; }

    }
}
 