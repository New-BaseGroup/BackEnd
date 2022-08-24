using DAL;
using DAL.Models;

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
        public Budget Findbudget(int budgetID)
        {
            using (var db = new BudgetContext())
            {
                var budget = db.Budgets.Find(budgetID);
                return budget;
            }
        }
        public void CreateBudget(string BudgetName, int TotalAmount, DateTime StartDate, DateTime EndDate, string Description, int UserId, BudgetCategory BudgetCategories)
        {
            var budget = new Budget()
            {
                Name = BudgetName,
                TotalAmount = TotalAmount,
                StartDate = StartDate,
                EndDate = EndDate,
                Description = Description,
                BudgetCategories = new List<BudgetCategory> { BudgetCategories }
            };

            using (var db = new BudgetContext())
            {
                db.Budgets.Add(budget);
                db.SaveChanges();
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
