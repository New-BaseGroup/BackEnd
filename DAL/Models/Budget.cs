using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Budget
    {
        [Key]
        public int BudgetID { get; set; }
            public string Name { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, 999999999999999999.99)]
        public int TotalAmount { get; set; }
        public DateTime StartDate { get; set; }/* = DateTime.Now;*/
        public DateTime EndDate { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<BudgetCategory> BudgetCategories { get; set;}

    }
}
