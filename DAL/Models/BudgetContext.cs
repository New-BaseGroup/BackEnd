using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
  

namespace DAL.Models
{
    public class BudgetContext : IdentityDbContext<AppUser>
    {
        public BudgetContext(DbContextOptions<BudgetContext> options)
            : base(options)
        {
        }


        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Change> Changes { get; set; }
        public DbSet<BudgetCategory> BudgetCategories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var connectionString = @"Server=.\SQLExpress; Database = NewGroup5; Integrated Security=True;MultipleActiveResultSets=true";

            builder.UseSqlServer(connectionString).UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Budget>().HasKey(u => u.BudgetID);
            modelBuilder.Entity<BudgetCategory>().HasKey(u => u.BudgetCategoryID);
            modelBuilder.Entity<Category>().HasKey(u => u.CategoryID);
            modelBuilder.Entity<Change>().HasKey(u => u.ChangeID);
            modelBuilder.Entity<Budget>().HasIndex(u => u.Name).IsUnique();
            modelBuilder.Entity<Category>().HasIndex(u => u.Name).IsUnique();

        }
    }
}