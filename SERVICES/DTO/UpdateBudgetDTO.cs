using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICES.DTO
{
    public class UpdateBudgetDTO
    {
        public int budgetID { get; set; }
        public string? CustomeName { get; set; }
        public int? TotalAmount { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Description { get; set; }
    }
}
