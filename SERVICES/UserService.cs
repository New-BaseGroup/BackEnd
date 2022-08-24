using DAL;
using DAL.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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

        public bool Login(string user, string password)
        {
            try
            {
                if (user != null && password != null)
                {
                    using (var context = new BudgetContext())
                    {

                        var findUser = context.Users.First(a => a.Username == user);
                        var hashedPassword = findUser.Password;
                        if (PasswordHasherService.VerifyPassword(password, hashedPassword))
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
        public bool RegisterNewAccount(string userName, string password, string mail)
        {
            try
            {
                using (var context = new BudgetContext())
                {

                    var emailString = @"^[\w-_]+(\.[\w!#$%'*+\/=?\^`{|}]+)*@((([\-\w]+\.)+[a-zA-Z]{2,20})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
                    Match match = Regex.Match(mail, emailString);

                    
                    var findUser = context.Users.First(a => a.Username == userName);
                    if (findUser != null)
                        return false;

                    if (match.Success)
                    {
                        var safePassword = PasswordHasherService.Hash(password);
                        var newUser = new User() { Username = userName, Password = safePassword, Email = mail };
                        context.Add(newUser);
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
