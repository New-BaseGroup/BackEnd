using Microsoft.EntityFrameworkCore;
using DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.ModelExtensions
{
    public static class Data
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            var user1 = new User { UserID = 1, Email = "Adam@gmail.com", Username = "Adam", Password = "0XepCVJtI65/eqjMxKR9s/4l0ENjank3fVdkrXghTC0=@TPS8UlUWVKfcpQuE1jXDOg==" }; //qwerty12345
            var user2 = new User { UserID = 2, Email = "Kim@gmail.com", Username = "Kim", Password = "0XepCVJtI65/eqjMxKR9s/4l0ENjank3fVdkrXghTC0=@TPS8UlUWVKfcpQuE1jXDOg==" };
            var user3 = new User { UserID = 3, Email = "Omar@gmail.com", Username = "Omar", Password = "0XepCVJtI65/eqjMxKR9s/4l0ENjank3fVdkrXghTC0=@TPS8UlUWVKfcpQuE1jXDOg==" };
            var user4 = new User { UserID = 4, Email = "Ahmad@gmail.com", Username = "Ahmad", Password = "0XepCVJtI65/eqjMxKR9s/4l0ENjank3fVdkrXghTC0=@TPS8UlUWVKfcpQuE1jXDOg==" };
            modelBuilder.Entity<User>()
                .HasData(user1, user2, user3, user4);
            modelBuilder.Entity<Budget>().HasData(
                new { BudgetID = 1,TotalAmount = 40000, Name = "budgetNr1", StartDate = DateTime.Now.AddDays(-10), EndDate = DateTime.Now.AddDays(20) , UserID = 1 },
                new { BudgetID = 2,TotalAmount = 20000, Name = "budgetNr2", StartDate = DateTime.Now.AddDays(-10), EndDate = DateTime.Now.AddDays(20), UserID = 1 },
                new { BudgetID = 3,TotalAmount = 10000, Name = "budgetNr1", StartDate = DateTime.Now.AddDays(-10), EndDate = DateTime.Now.AddDays(20), UserID = 2 },
                new { BudgetID = 4,TotalAmount = 10000, Name = "budgetNr2", StartDate = DateTime.Now.AddDays(-10), EndDate = DateTime.Now.AddDays(20), UserID = 2 },
                new { BudgetID = 5,TotalAmount = 10000, Name = "budgetNr1", StartDate = DateTime.Now.AddDays(-10), EndDate = DateTime.Now.AddDays(20), UserID = 3 },
                new { BudgetID = 6,TotalAmount = 10000, Name = "budgetNr2", StartDate = DateTime.Now.AddDays(-10), EndDate = DateTime.Now.AddDays(20), UserID = 3 },
                new { BudgetID = 7,TotalAmount = 10000, Name = "budgetNr1", StartDate = DateTime.Now.AddDays(-10), EndDate = DateTime.Now.AddDays(20), UserID = 4 },
                new { BudgetID = 8,TotalAmount = 10000, Name = "budgetNr2", StartDate = DateTime.Now.AddDays(-10), EndDate = DateTime.Now.AddDays(20), UserID = 4 });
            modelBuilder.Entity<Category>().HasData(
                new { Name = "Food", CategoryID = 1 },
                new { Name = "Fuel", CategoryID = 2 },
                new { Name = "Clothes", CategoryID = 3 },
                new { Name = "Furniture", CategoryID = 4 },
                new { Name = "House", CategoryID = 5 },
                new { Name = "NotHouse", CategoryID = 6 }
                );
            modelBuilder.Entity<BudgetCategory>().HasData(
                new { BudgetCategoryID = 1,  CustomName = "BudgetCategory1",  MaxAmount = 10000, CategoryID = 1, BudgetID = 1 },
                new { BudgetCategoryID = 2,  CustomName = "BudgetCategory2",  MaxAmount = 10000, CategoryID = 2, BudgetID = 1 },
                new { BudgetCategoryID = 3,  CustomName = "BudgetCategory3",  MaxAmount = 10000, CategoryID = 3, BudgetID = 1 },
                new { BudgetCategoryID = 4,  CustomName = "BudgetCategory4",  MaxAmount = 10000, CategoryID = 4, BudgetID = 1 },
                new { BudgetCategoryID = 5,  CustomName = "BudgetCategory5",  MaxAmount = 10000, CategoryID = 5, BudgetID = 2 },
                new { BudgetCategoryID = 6,  CustomName = "BudgetCategory6",  MaxAmount = 10000, CategoryID = 1, BudgetID = 2 },
                new { BudgetCategoryID = 7,  CustomName = "BudgetCategory7",  MaxAmount = 10000, CategoryID = 2, BudgetID = 3 },
                new { BudgetCategoryID = 8,  CustomName = "BudgetCategory8",  MaxAmount = 10000, CategoryID = 3, BudgetID = 4 },
                new { BudgetCategoryID = 9,  CustomName = "BudgetCategory9",  MaxAmount = 10000, CategoryID = 4, BudgetID = 5 },
                new { BudgetCategoryID = 10, CustomName = "BudgetCategory10", MaxAmount = 10000, CategoryID = 5, BudgetID = 6 },
                new { BudgetCategoryID = 11, CustomName = "BudgetCategory11", MaxAmount = 10000, CategoryID = 6, BudgetID = 7 },
                new { BudgetCategoryID = 12, CustomName = "BudgetCategory12", MaxAmount = 10000, CategoryID = 6, BudgetID = 8 }
                );
            modelBuilder.Entity<Change>().HasData(
                new { ChangeID = 1, Title = "income test test1", Amount = 11000, Date = DateTime.Now, Description = "test Description 1", BudgetCategoryID = 1 },
                new { ChangeID = 2, Title = "income test test2", Amount = -2000, Date = DateTime.Now, Description = "test Description 1", BudgetCategoryID = 1 },
                 new { ChangeID = 3, Title = "income test test3", Amount = 30000, Date = DateTime.Now, Description = "test Description 1", BudgetCategoryID = 2 },
                new { ChangeID = 4, Title = "income test test4", Amount = -1000, Date = DateTime.Now, Description = "test Description 1", BudgetCategoryID = 2 },
                new { ChangeID = 5, Title = "income test test5", Amount = -2000, Date = DateTime.Now, Description = "test Description 1", BudgetCategoryID = 3 },
                new { ChangeID = 6, Title = "income test test6", Amount = -3000, Date = DateTime.Now, Description = "test Description 1", BudgetCategoryID = 4 },
                 new { ChangeID = 7, Title = "income test test7", Amount = -3000, Date = DateTime.Now, Description = "test Description 1", BudgetCategoryID = 5 },
                new { ChangeID = 8, Title = "income test test8", Amount = -3000, Date = DateTime.Now, Description = "test Description 1", BudgetCategoryID = 6 },
                new { ChangeID = 9, Title = "income test test9", Amount = -3000, Date = DateTime.Now, Description = "test Description 1", BudgetCategoryID = 7 },
                new { ChangeID = 10, Title = "income test test10", Amount = -3000, Date = DateTime.Now, Description = "test Description 1", BudgetCategoryID = 8 },
                 new { ChangeID = 11, Title = "income test test11", Amount = -3000, Date = DateTime.Now, Description = "test Description 1", BudgetCategoryID = 3 },
                new { ChangeID = 12, Title = "income test test12", Amount = -3000, Date = DateTime.Now, Description = "test Description 1", BudgetCategoryID = 3 }
                );

                }
    }
}


