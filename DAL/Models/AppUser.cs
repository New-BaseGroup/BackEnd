using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace DAL.Models
{
    public class AppUser : IdentityUser
    {
        public virtual ICollection<Budget>? Budgets { get; set; }
    }
}