using Microsoft.EntityFrameworkCore;
using DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.ModelExtensions
{
    public static class Data
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            var user1 = new User { UserID = 1, Email = "Adam@gmail.com", Username = "Adam", Password = "qwerty123" };
            var user2 = new User { UserID = 2, Email = "Kim@gmail.com", Username = "Kim", Password = "qwerty123" };
            var user3 = new User { UserID = 3, Email = "Omar@gmail.com", Username = "Omar", Password = "qwerty123" };
            var user4 = new User { UserID = 4, Email = "Ahmad@gmail.com", Username = "Ahmad", Password = "qwerty123" };
            modelBuilder.Entity<User>()
                .HasData(user1, user2, user3, user4);
            modelBuilder.Entity<Budget>().HasData(
                new { BudgetID = 1,TotalAmount = 6000, Name = "budgetNr1", StartDate = DateTime.Parse("2022-04-21"), EndDate = DateTime.Parse("2022-04-22"), UserID = 1 },
                new { BudgetID = 2,TotalAmount = 6000, Name = "budgetNr2", StartDate = DateTime.Parse("2022-04-21"), EndDate = DateTime.Parse("2022-04-22"), UserID = 1 },
                new { BudgetID = 3,TotalAmount = 6000, Name = "budgetNr1", StartDate = DateTime.Parse("2022-04-21"), EndDate = DateTime.Parse("2022-04-22"), UserID = 2 },
                new { BudgetID = 4,TotalAmount = 6000, Name = "budgetNr2", StartDate = DateTime.Parse("2022-04-21"), EndDate = DateTime.Parse("2022-04-22"), UserID = 2 },
                new { BudgetID = 5,TotalAmount = 6000, Name = "budgetNr1", StartDate = DateTime.Parse("2022-04-21"), EndDate = DateTime.Parse("2022-04-22"), UserID = 3 },
                new { BudgetID = 6,TotalAmount = 6000, Name = "budgetNr2", StartDate = DateTime.Parse("2022-04-21"), EndDate = DateTime.Parse("2022-04-22"), UserID = 3 },
                new { BudgetID = 7,TotalAmount = 6000, Name = "budgetNr1", StartDate = DateTime.Parse("2022-04-21"), EndDate = DateTime.Parse("2022-04-22"), UserID = 4 },
                new { BudgetID = 8,TotalAmount = 6000, Name = "budgetNr2", StartDate = DateTime.Parse("2022-04-21"), EndDate = DateTime.Parse("2022-04-22"), UserID = 4 });
            modelBuilder.Entity<Category>().HasData(
                new { Name = "Food", CategoryID = 1 },
                new { Name = "Fuel", CategoryID = 2 },
                new { Name = "Clothes", CategoryID = 3 },
                new { Name = "Furniture", CategoryID = 4 },
                new { Name = "House", CategoryID = 5 },
                new { Name = "NotHouse", CategoryID = 6 }
                );
            modelBuilder.Entity<BudgetCategory>().HasData(
                new { BudgetCategoryID = 1,  CustomName = "BudgetCategory1",  MaxAmount = 10, CategoryID = 1, BudgetID = 1 },
                new { BudgetCategoryID = 2,  CustomName = "BudgetCategory2",  MaxAmount = 10, CategoryID = 2, BudgetID = 2 },
                new { BudgetCategoryID = 3,  CustomName = "BudgetCategory3",  MaxAmount = 10, CategoryID = 3, BudgetID = 3 },
                new { BudgetCategoryID = 4,  CustomName = "BudgetCategory4",  MaxAmount = 10, CategoryID = 4, BudgetID = 4 },
                new { BudgetCategoryID = 5,  CustomName = "BudgetCategory5",  MaxAmount = 10, CategoryID = 5, BudgetID = 5 },
                new { BudgetCategoryID = 6,  CustomName = "BudgetCategory6",  MaxAmount = 10, CategoryID = 1, BudgetID = 6 },
                new { BudgetCategoryID = 7,  CustomName = "BudgetCategory7",  MaxAmount = 10, CategoryID = 2, BudgetID = 7 },
                new { BudgetCategoryID = 8,  CustomName = "BudgetCategory8",  MaxAmount = 10, CategoryID = 3, BudgetID = 8 },
                new { BudgetCategoryID = 9,  CustomName = "BudgetCategory9",  MaxAmount = 10, CategoryID = 4, BudgetID = 1 },
                new { BudgetCategoryID = 10, CustomName = "BudgetCategory10", MaxAmount = 10, CategoryID = 5, BudgetID = 2 },
                new { BudgetCategoryID = 11, CustomName = "BudgetCategory11", MaxAmount = 10, CategoryID = 6, BudgetID = 3 },
                new { BudgetCategoryID = 12, CustomName = "BudgetCategory12", MaxAmount = 10, CategoryID = 6, BudgetID = 4 }
                );
        }
    }
}


