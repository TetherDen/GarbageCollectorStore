using GarbageCollectorStore.Users.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GarbageCollectorStore
{
    internal static class UserManager
    {
        private static List<User> _usersList = new List<User>();
        public static List<User> UsersList { get { return _usersList; } }
        internal static User CurrentUser { get; set; } = null;
        public static User Login()
        {
            Console.WriteLine(TextColor.RequestText("Enter your login:"));
            string login = Console.ReadLine();
            Console.WriteLine(TextColor.RequestText("Enter your password:"));
            string password = Console.ReadLine();
            var user = UsersList.FirstOrDefault(user => user.Login == login && user.Password == password);
            if(user != null)
            {
                Console.WriteLine(TextColor.SuccessfulText($"Welcome back, {user.Login}!"));
            }
            else
            {
                Console.WriteLine(TextColor.ErrorText("Invalid login or password. Please try again."));
            }
            return user;
        }


        public static void ShowAdmin()   //  TODO: hide or remove
        {
            if (_usersList.Count > 0 && _usersList[0] is Admin)
            {
                Console.WriteLine(_usersList[0]);
            }
            //  TODO:  else here ?
        }

    }
}
