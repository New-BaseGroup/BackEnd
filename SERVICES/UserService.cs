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
        public bool RegisterNewAccount(RegisterUserDTO newUser)
        {
            try
            {
                using (var context = new BudgetContext())
                {

                    var emailString = @"^[\w-_]+(\.[\w!#$%'*+\/=?\^`{|}]+)*@((([\-\w]+\.)+[a-zA-Z]{2,20})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
                    Match match = Regex.Match(newUser.Email, emailString);

                    
                    var findUser = context.Users.First(a => a.Username == newUser.User);
                    if (findUser != null)
                        return false;

                    if (match.Success)
                    {
                        var safePassword = PasswordHasherService.Hash(newUser.Password);
                        var user = new User() { Username = newUser.User, Password = safePassword, Email = newUser.Email };
                        context.Add(user);
                        context.SaveChanges();
                        return true;
                    }
                    return true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
