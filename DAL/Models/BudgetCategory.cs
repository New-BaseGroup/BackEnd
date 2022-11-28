using Castle.Components.DictionaryAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class BudgetCategory
    {
        
        public int BudgetCategoryID { get; set; }
        public string CustomName { get; set; }
        public int MaxAmount { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Change>? Changes { get; set; }
    }
}
