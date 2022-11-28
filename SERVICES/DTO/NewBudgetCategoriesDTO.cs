using System.ComponentModel.DataAnnotations;
using DAL.Models;
namespace SERVICES.DTO
{
    public class NewBudgetCategoriesDTO
    {

        [Required]
        public int CategoryID { get; set; }
        public string CustomName { get; set; }

        [Required]
        public int MaxAmount { get; init; }

    }
}
