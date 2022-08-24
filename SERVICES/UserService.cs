using DAL;
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

        public Boolean Login(string user, string password)
        {
            if (user != null && password != null)
            {
                using (var context = new BudgetContext())
                {
                    //implement when db is up and runing
                    var findUser = context.Users.First(a => a.Username == user);
                    var hash = findUser.Password;
                    

                    //hash should be the users stored hashed password
                    //var result = PasswordHasher.VerifyHashedPassword(userPass, pass);
                    return true;
                }
            }
                
            else
                return false;
        }
        public Boolean RegisterNewAccount(string userName, string password, string mail)
        {
            using (var context = new BudgetContext())
            {

                var emailString = @"^[\w-_]+(\.[\w!#$%'*+\/=?\^`{|}]+)*@((([\-\w]+\.)+[a-zA-Z]{2,20})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
                Match match = Regex.Match(mail, emailString);

                var findUser = "admin";
                //var findUser = context.Users.First(a => a.user == userName);
                if (findUser != null)
                    return false;

                //var hash = PasswordHasher.Hash(password);
                //save password and user name / email in db 
                //var newUser = new User() { UserName = userName, Password = hash, Email = mail};
                return true;
                //save hash to databas as the users password.
            }
        }
    }
}
