using DAL.Models;
using DAL.ModelExtensions;
using Microsoft.EntityFrameworkCore;


namespace DAL
{
    public class BudgetContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Change> Changes { get; set; }
        public DbSet<BudgetCategory> BudgetCategories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var connectionString = @"Server=.\SQLExpress; Database = NewGroup5; Integrated Security=True";

            builder.UseSqlServer(connectionString).UseLazyLoadingProxies();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u=>u.UserID);
            modelBuilder.Entity<Budget>().HasKey(u=>u.BudgetID);
            modelBuilder.Entity<BudgetCategory>().HasKey(u=>u.BudgetCategoryID);
            modelBuilder.Entity<Category>().HasKey(u=>u.CategoryID);
            modelBuilder.Entity<Change>().HasKey(u=>u.ChangeID);
            
            modelBuilder.Entity<User>().HasIndex(u=>u.Username).IsUnique();
            modelBuilder.Entity<User>().HasIndex(u=>u.Email).IsUnique();
            modelBuilder.Entity<Budget>().HasIndex(u=>u.Name).IsUnique();
            modelBuilder.Entity<Category>().HasIndex(u=>u.Name).IsUnique();
            modelBuilder.Seed();

        }

    }
}
