using System.ComponentModel.DataAnnotations;
namespace API.DTO
{
    public class BudgetCategoriesDTO
    {

        [Required]
        public int CatergoriID { get; set; }
        public string CustomName { get; set; }

        [Required]
        public int MaxAmount { get; init; }

    }
}
 