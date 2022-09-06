using DAL;
using DAL.Models;
using SERVICES.DTO;
using SERVICES;

namespace SERVICES
{
    public class BudgetService
    {
        private static BudgetService _instance;
        public static BudgetService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BudgetService();
                }
                return _instance;
            }
        }
        private BudgetService() { }
        public ICollection<Budget> ListAllBudgets(int UserID)
        {
            using (var db = new BudgetContext())
            {
                var budgets = db.Users.First(u => u.UserID == UserID).Budgets;
                return budgets;
            }
        }
        public BudgetDTO GetBudgetById(int budgetID)
        {
            using (var db = new BudgetContext())
            {
                var budget = db.Budgets.First(b => b.BudgetID == budgetID);
                var budgetCategories = new List<BudgetCategoriesDTO>();
                foreach (var item in budget.BudgetCategories)
                {
                    
                    budgetCategories.Add(new BudgetCategoriesDTO() { CatergoriID = item.Category.CategoryID, CustomName = item.CustomName, MaxAmount = item.MaxAmount,BalanceChanges = item.Changes.ToList() });
                }

                var foundBudget = new BudgetDTO()
                {
                    BudgetID = budget.BudgetID,
                    Name = budget.Name,
                    TotalAmount = budget.TotalAmount,
                    StartDate = budget.StartDate,
                    EndDate = budget.EndDate,
                    Description = budget.Description,
                    BudgetCategories = budgetCategories,
                };
                return foundBudget;
               
            }
        }
        public bool CreateBudget(CreateBudgetDTO inputBudget)
        {
            try
                {
                using (var db = new BudgetContext())
                {
                    var BudgetCategoriesList = new List<BudgetCategory>();
                    foreach (var item in inputBudget.BudgetCategories)
                    {
                        BudgetCategoriesList.Add(new BudgetCategory() { CustomName = item.CustomName, MaxAmount = item.MaxAmount, Category = db.Categories.First(c => c.CategoryID == item.CatergoriID) });
                    }
                    var budget = new Budget()
                    {
                        Name = inputBudget.BudgetName,
                        TotalAmount = inputBudget.TotalAmount,
                        StartDate = inputBudget.StartDate,
                        EndDate = inputBudget.EndDate,
                        Description = inputBudget.Description,
                        BudgetCategories = BudgetCategoriesList
                    };

                    var UserBudget = db.Users.First(u => u.UserID == inputBudget.UserId).Budgets;
                    
                    UserBudget.Add(budget);
                    db.SaveChanges();
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
           
        }
        public void UpdateBudget(int? budgetID, string? BudgetName, int TotalAmount, DateTime StartDate, DateTime EndDate, string? Description)
        {
            using (var db = new BudgetContext())
            {
                var Currentbudget = db.Budgets.Find(budgetID);
                if (Currentbudget == null)
                    throw new NullReferenceException($"No Currentbudget found with Id: {budgetID}");
                if (!string.IsNullOrEmpty(BudgetName))
                    Currentbudget.Name = BudgetName;
                if (!string.IsNullOrEmpty(Description))
                    Currentbudget.Description = Description;
                if (TotalAmount != null)
                    Currentbudget.TotalAmount = TotalAmount;
                if (StartDate != null)
                    Currentbudget.StartDate = StartDate;
                if (EndDate != null)
                    Currentbudget.EndDate = EndDate;
                db.Budgets.Update(Currentbudget);
                db.SaveChanges();
            }
        }
        public void DeleteBudget(int budgetID)
        {
            using (var db = new BudgetContext())
            {
                var budget = db.Budgets.Find(budgetID);
                db.Budgets.Remove(budget);
                db.SaveChanges();
            }
        }
    }
}
