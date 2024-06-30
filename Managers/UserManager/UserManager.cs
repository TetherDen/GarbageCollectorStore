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
                if(login.Length >= Config.MinLoginLength)
                {
                    if (!isUserRegistered(login))
                    {
                        Console.WriteLine("Enter your password:");
                        string password = Console.ReadLine();
                        if(password.Length >= Config.MinPasswordLength)
                        {
                            //Admin admin = new Admin(login, password);
                            usersList.Insert(0, new Admin(login, password));
                        }
                        else
                        {
                            Console.WriteLine("Password length must be more than 5 characters.");
                        }                      
                    }
                    else
                    {
                        Console.WriteLine("This login is already used.");
                    }
                }
                else
                {
                    Console.WriteLine("Login length must be more than 4 characters.");
                }
            }
        }



    }
}
