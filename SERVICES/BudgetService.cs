using DAL;
using DAL.Models;
using SERVICES.DTO;
using SERVICES;
using Castle.Core.Internal;
using DAL.ModelExtensions;

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
        public ICollection<GetBudgetDTO> ListAllBudgets(int UserID)
        {
            using (var db = new BudgetContext())
            {
                var AllUserBudgets = new List<GetBudgetDTO>(); ;
                foreach (Budget item in db.Users.First(u => u.UserID == UserID).Budgets)
                {
                    var budgetDTO = new GetBudgetDTO()
                    {
                        BudgetID = item.BudgetID,
                        CustomeName = item.Name,
                        TotalAmount = item.TotalAmount,
                        Description = item.Description,
                        StartDate = item.StartDate,
                        EndDate = item.EndDate
                    };
                    AllUserBudgets.Add(budgetDTO);
                }
                return AllUserBudgets;
            }
        }
        public List<GetBudgetDTO> GetBudgets(GetBudgetDTO inputBudgetInfo)
        {
            var AllUserBudgets = ListAllBudgets(inputBudgetInfo.UserID);
            var Budgets = new List<GetBudgetDTO>();
            if (inputBudgetInfo.BudgetID != null)
                Budgets.Add(AllUserBudgets.First(b => b.BudgetID == inputBudgetInfo.BudgetID));
            if (!string.IsNullOrEmpty(inputBudgetInfo.CustomeName))
                Budgets.Add(AllUserBudgets.First(b => b.CustomeName == inputBudgetInfo.CustomeName));
            if (inputBudgetInfo.StartDate != null && inputBudgetInfo.EndDate != null)
            {
                var tempbudget = AllUserBudgets.Where(b =>
                    b.StartDate <= inputBudgetInfo.StartDate &&
                    b.StartDate <= inputBudgetInfo.EndDate &&
                    b.EndDate >= inputBudgetInfo.EndDate &&
                    b.EndDate >= inputBudgetInfo.StartDate).ToList();
                Budgets = Budgets.Union(tempbudget).ToList();
            }
            if (inputBudgetInfo.StartDate != null)
            {
                var tempbudget = AllUserBudgets.Where(b => b.StartDate <= inputBudgetInfo.StartDate).ToList();
                Budgets = Budgets.Union(tempbudget).ToList();
            }
            if (inputBudgetInfo.EndDate != null)
            {
                var tempbudget = AllUserBudgets.Where(b => b.EndDate >= inputBudgetInfo.EndDate).ToList();
                Budgets = Budgets.Union(tempbudget).ToList();
            }
            return Budgets;
        }
        public BudgetDTO GetBudgetById(int budgetID)
        {
            using (var db = new BudgetContext())
            {
                var budget = db.Budgets.First(b => b.BudgetID == budgetID);
                var budgetCategories = new List<BudgetCategoriesDTO>();
                foreach (var item in budget.BudgetCategories)
                {

                    budgetCategories.Add(new BudgetCategoriesDTO()
                    {
                        CatergoriID = item.Category.CategoryID,
                        CustomName = item.CustomName,
                        MaxAmount = item.MaxAmount,
                        BalanceChanges = item.Changes.ToList()
                    });
                }

                var foundBudget = new BudgetDTO()
                {
                    BudgetID = budget.BudgetID,
                    Name = budget.Name,
                    TotalAmount = budget.TotalAmount,
                    StartDate = DateOnly.FromDateTime(budget.StartDate.Date),
                    EndDate = DateOnly.FromDateTime(budget.EndDate),
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
                        BudgetCategoriesList.Add(new BudgetCategory()
                        {
                            CustomName = item.CustomName,
                            MaxAmount = item.MaxAmount,
                            Category = db.Categories.First(c => c.CategoryID == item.CatergoriID)
                        });
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
        public bool UpdateBudget(GetBudgetDTO budgetDTO)
        {
            try
            {
                using (var db = new BudgetContext())
                {
                    var Currentbudget = db.Budgets.Find(budgetDTO.BudgetID);
                    if (Currentbudget == null)
                        throw new NullReferenceException($"No Currentbudget found with Id: {budgetDTO.BudgetID}");
                    if (!string.IsNullOrEmpty(budgetDTO.CustomeName))
                        Currentbudget.Name = budgetDTO.CustomeName;
                    if (!string.IsNullOrEmpty(budgetDTO.Description))
                        Currentbudget.Description = budgetDTO.Description;
                    if (budgetDTO.TotalAmount != null)
                        Currentbudget.TotalAmount = (int)budgetDTO.TotalAmount;
                    if (budgetDTO.StartDate != null)
                        Currentbudget.StartDate = (DateTime)budgetDTO.StartDate;
                    if (budgetDTO.EndDate != null)
                        Currentbudget.EndDate = (DateTime)budgetDTO.EndDate;
                    db.Budgets.Update(Currentbudget);
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
        public bool DeleteBudget(int budgetID)
        {
            try
            {
                using (var db = new BudgetContext())
                {
                    var budget = db.Budgets.Find(budgetID);
                    db.Budgets.Remove(budget);
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
    }
}
