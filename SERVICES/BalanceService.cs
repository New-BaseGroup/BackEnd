using Castle.Core.Internal;
using DAL;
using DAL.Models;
using MailKit;
using SERVICES.DTO;

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
        public bool AddChange(BalanceChangeDTO balanceChange)
        {
            try
            {

            
            var change = new Change()
            {
                Title = balanceChange.Title,
                Amount = balanceChange.Amount,
                Date = balanceChange.Date,
                Description = balanceChange.Description,
            };
            using (var db = new BudgetContext())
            {

                    var budgetCategoriesDB = db.BudgetCategories.First(g => g.BudgetCategoryID == balanceChange.BudgetCategoryID);
                    
                    if (budgetCategoriesDB != null)
                    {
                        budgetCategoriesDB.Changes.Add(change);
                        db.SaveChanges();
                        return true;
                    }
                    Console.WriteLine("test2");
                    return false;
            }
                Console.WriteLine("test3");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool DeleteChange(int ChangeID)
        {
            try 
            {
                using (var db = new BudgetContext())
                {
                    var change = db.Changes.Find(ChangeID);
                    db.Changes.Remove(change);
                    db.SaveChanges();
                    return true;
                }
                return false;

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool UpdateChange(UpdateChangeDTO ChangeDto)
        {
            try
            {
                using (var context = new BudgetContext())
                {
                    var Change = context.Changes.FirstOrDefault(x => x.ChangeID == ChangeDto.ID);

                    if (Change == null)
                        throw new NullReferenceException($"No Change found with Id: {ChangeDto.ID}");

                    if (!string.IsNullOrEmpty(ChangeDto.Title))
                        Change.Title = ChangeDto.Title;

                    if (!string.IsNullOrEmpty(ChangeDto.Description))
                        Change.Description = ChangeDto.Description;

                    if (ChangeDto.Amount != null)
                        Change.Amount = ChangeDto.Amount.Value;

                    if (ChangeDto.Date != null)
                        Change.Date = ChangeDto.Date.Value;
                    context.Changes.Update(Change);
                    context.SaveChanges();
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

    }
}
