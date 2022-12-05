using DAL;
using DAL.Models;
using SERVICES.DTO;
using System.Text.RegularExpressions;


namespace SERVICES
{
    public class UserService
    {
        private static UserService _instance;
        public static UserService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserService();
                }
                return _instance;
            }
        }
        private UserService() { }

        public bool Login(LoginDTO userInputs)
        {
            try
            {
                if (userInputs.User != null && userInputs.Password != null)
                {
                    using (var context = new BudgetContext())
                    {

                        var findUser = context.Users.First(a => a.Username == userInputs.User);
                        var hashedPassword = findUser.Password;
                        if (PasswordHasherService.VerifyPassword(userInputs.Password, hashedPassword))
                            return true;
                        else
                            return false;

                    }
                }

                else
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public int GetUserId(string user)
        {
            try
            {
                using (var db = new BudgetContext())
                {
                    var userID = db.Users.First(u => u.Username == user).UserID;
                    return userID;
                }
            }
            catch { return 0; }
           
        }
        public bool RegisterNewAccount(RegisterUserDTO newUser)
        {
            //try
            //{
                using (var context = new BudgetContext())
                {

                    var emailString = @"^[\w-_]+(\.[\w!#$%'*+\/=?\^`{|}]+)*@((([\-\w]+\.)+[a-zA-Z]{2,20})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
                    Match match = Regex.Match(newUser.Email, emailString);

                    
                    var findUser = context.Users.FirstOrDefault(a => a.Username == newUser.User || a.Email == newUser.Email);
                    if (findUser != null)
                    {
                    Console.WriteLine("wtf");
                    return false;
                    }

                    if (match.Success)
                    {
                        var safePassword = PasswordHasherService.Hash(newUser.Password);
                        var user = new User() { Username = newUser.User, Password = safePassword, Email = newUser.Email };
                        context.Users.Add(user);
                        context.SaveChanges();
                        return true;
                    }
                    return false;

                }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("service");
            //    Console.WriteLine(ex.Message);
            //    return false;
            //}
        }
        public ICollection<Widget> getAllWidgets(int UserID)
        {
            using (var db = new BudgetContext())
            {
                var AllUserBudgets = new List<Widget>(); ;
                foreach (Widget item in db.Users.First(u => u.UserID == UserID).Widgets)
                {
                    var widget = new Widget()
                    {
                        WidgetID = item.WidgetID,
                        Header = item.Header,
                        Data = item.Data,
                    };
                    AllUserBudgets.Add(widget);
                }
                return AllUserBudgets;
            }
        }
        public bool SaveWidgets(List<WidgetDTO> inputWidgets, int UserID)
        {
            try
            {
                using (var db = new BudgetContext())
                {
                    var WidgetList = new List<Widget>();
                    var User = db.Users.First(u => u.UserID == UserID);
                    foreach (var item in inputWidgets)
                    {
                        WidgetList.Add(new Widget()
                        {
                            Header = item.Header,
                            Data = item.Data,
                        });
                    }

                    User.Widgets = WidgetList;
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
