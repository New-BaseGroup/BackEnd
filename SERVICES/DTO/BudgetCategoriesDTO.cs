using System.ComponentModel.DataAnnotations;
using DAL.Models;
namespace SERVICES.DTO
{
    public class BudgetCategoriesDTO
    {

        [Required]
        public int CatergoriID { get; set; }
        public string CustomName { get; set; }

        [Required]
        public int MaxAmount { get; init; }

        public List<Change>? BalanceChanges { get; set; }
    }
}
 