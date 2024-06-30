using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorStore
{
    internal class UserManager
    {
        private List<User> usersList = new List<User>();

        private bool isUserRegistered(string login)
        {
            foreach (var user in usersList)
            {
                if (user.Login == login)
                {
                    return true;
                }
            }
            return false;
        }

        public void AdminRegister()
        {
            while(true)
            {
                Console.WriteLine("Enter your login:");
                string login = Console.ReadLine();
                if(login.Length >= Config.MIN_LOGIN_LENGTH)
                {
                    if (!isUserRegistered(login))
                    {
                        Console.WriteLine("Enter your password:");
                        string password = Console.ReadLine();
                        if(password.Length >= Config.MIN_PASSWORD_LENGTH)
                        {
                            usersList.Insert(0, new Admin(login, password));
                            Console.WriteLine(Config.SuccessfulText("You have successfully registered."));
                            break;
                        }
                        else
                        {
                            Console.WriteLine(Config.ErrorText("Password length must be more than 5 characters."));
                        }                      
                    }
                    else
                    {
                        Console.WriteLine(Config.ErrorText("This login is already used."));
                    }
                }
                else
                {
                    Console.WriteLine(Config.ErrorText("Login length must be more than 4 characters."));
                }
            }
        }
        public void ShowAdmin()
        {
            Console.WriteLine(usersList[0]);
        }


    }
}
