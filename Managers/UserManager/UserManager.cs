using GarbageCollectorStore.Users.Customer;
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

        private (string,string) ValidateLoginPassword()
        {
            while (true)
            {
                Console.WriteLine("Enter your login:");
                string login = Console.ReadLine();
                if (login.Length >= Config.MIN_LOGIN_LENGTH)
                {
                    if (!isUserRegistered(login))
                    {
                        Console.WriteLine("Enter your password:");
                        string password = Console.ReadLine();
                        if (password.Length >= Config.MIN_PASSWORD_LENGTH)
                        {
                            return (login, password);
                            //usersList.Insert(0, new Admin(login, password));
                            //Console.WriteLine(Config.SuccessfulText("You have successfully registered."));  // вынести
                            //break;
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

        public void AdminRegister()
        {
            (string login,string password) = ValidateLoginPassword();  // ( кортеж стрингов )
            if (login != null && password != null)
            {
                User admin = new Admin(login, password);
                usersList.Insert(0, admin);
                Console.WriteLine(Config.SuccessfulText("You have successfully registered."));
            }
            // TODO: add throw?


            //while(true)
            //{
            //    Console.WriteLine("Enter your login:");
            //    string login = Console.ReadLine();
            //    if(login.Length >= Config.MIN_LOGIN_LENGTH)
            //    {
            //        if (!isUserRegistered(login))
            //        {
            //            Console.WriteLine("Enter your password:");
            //            string password = Console.ReadLine();
            //            if(password.Length >= Config.MIN_PASSWORD_LENGTH)
            //            {
            //                usersList.Insert(0, new Admin(login, password));
            //                //Console.WriteLine(Config.SuccessfulText("You have successfully registered."));  // вынести
            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine(Config.ErrorText("Password length must be more than 5 characters."));
            //            }                      
            //        }
            //        else
            //        {
            //            Console.WriteLine(Config.ErrorText("This login is already used."));
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine(Config.ErrorText("Login length must be more than 4 characters."));
            //    }
            //}
        }
        public void ShowAdmin()
        {
            Console.WriteLine(usersList[0]);
        }


    }
}
