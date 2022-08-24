using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [StringLength(100, MinimumLength = 1)]
        public string Email { get; set; }

        [StringLength(50, MinimumLength = 1)]
        public string Username { get; set; }

        [StringLength(50, MinimumLength = 1)]
        public string Password { get; set; }
        public virtual ICollection<Budget>? Budgets { get; set; }

    }
}
