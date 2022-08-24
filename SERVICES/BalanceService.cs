using DAL;
using DAL.Models;

namespace SERVICES
{
    public class BalanceService
    {
        private static BalanceService _instance;
        public static BalanceService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BalanceService();
                }
                return _instance;
            }
        }
        private BalanceService() { }
        public ICollection<Change> GetBalanceChanges(int BudgetCategoryID)
        {
            using (var db = new BudgetContext())
            {
                var changes = db.BudgetCategories.First(bc => bc.BudgetCategoryID == BudgetCategoryID).Changes;
                return changes;
            }
        }
        public Change GetBalanceChange(int ChangeID)
        {
            using (var db = new BudgetContext())
            {
                var change = db.Changes.Find(ChangeID);
                return change;
            }
        }
        public void AddChange(int BudgetCategoryID, int Amount, string Title, string Description, DateTime Date)
        {
            var change = new Change()
            {
                Title = Title,
                Description = Description,
                Amount = Amount,
                Date = Date
            };
            using (var db = new BudgetContext())
            {
                var budgetCategory = db.BudgetCategories.First(u => u.BudgetCategoryID == BudgetCategoryID).Changes;
                budgetCategory.Add(change);
                db.SaveChanges();
            }
        }
        public void DeleteChange(int ChangeID)
        {
            using (var db = new BudgetContext())
            {
                var change = db.Changes.Find(ChangeID);
                db.Changes.Remove(change);
                db.SaveChanges();
            }
        }
    }
}
