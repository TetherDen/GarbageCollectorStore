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
        private static List<User> usersList = new List<User>();

        private static bool isUserRegistered(string login)
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

        private static  (string,string) ValidateLoginPassword()
        {
            while (true)
            {
                Console.WriteLine(Config.RequestText("Enter your login:"));
                string login = Console.ReadLine();
                if (login.Length >= Config.MIN_LOGIN_LENGTH)
                {
                    if (!isUserRegistered(login))
                    {
                        Console.WriteLine(Config.RequestText("Enter your password:"));
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

        public static Admin AdminRegister()
        {
            (string login,string password) = ValidateLoginPassword();  // возвр.( кортеж стрингов )
            if (login != null && password != null)
            {
                Admin admin = new Admin(login, password);
                usersList.Insert(0, admin);

                return admin;
            }
            return null;
            // TODO: add throw?

        }
        public static bool isAdminRegistered()
        {
            return usersList.Count > 0 && usersList[0] is Admin;

        }
        public static Customer CustomerRegister()
        {
            (string login, string password) = ValidateLoginPassword();
            if (login != null && password != null)
            {
                Customer customer = new Customer(login, password);
                customer.Name = ValidateName();
                customer.Address = ValidateAddress();
                customer.Email = ValidateEmail();
                usersList.Add(customer);
                return customer;
            }
            return null;

        }
        //private static void RequestCustomerInformation()   // remove this method ?!
        //{
        //    // TODO:
        //    //Console.WriteLine("Enter your address:");
        //    //Console.WriteLine("Enter your email:");

        //}

        private static string ValidateName()
        {
            string name;
            while (true)
            {
                Console.WriteLine(Config.RequestText("Enter your name:"));
                name = Console.ReadLine();
                if (name.Length >= Config.MIN_NAME_LENGTH && Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine(Config.ErrorText("Name must be at least 3 characters and contain only letters. Please try again."));
                }
            }
            return name;
        }
        private static string ValidateAddress()
        {
            string address;
            while (true)
            {
                Console.WriteLine(Config.RequestText("Enter your address:"));
                address = Console.ReadLine();
                if (address.Length >= Config.MIN_ADDRESS_LENGTH)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(Config.ErrorText("Address must be longer than 3 characters. Please try again."));
                }
            }
            return address;
        }
        private static string ValidateEmail()
        {
            string email;
            while (true)
            {
                Console.WriteLine(Config.RequestText("Enter your email:"));
                email = Console.ReadLine();
                if (Regex.IsMatch(email,Config.EMAIL_REGEX))
                {
                    break;
                }
                else
                {
                    Console.WriteLine(Config.ErrorText("Please enter a valid email address."));
                }
            }
            return email;
        }


        public static void ShowAdmin()   //  Maybe Hide or private
        {
            if (usersList.Count > 0 && usersList[0] is Admin)
            {
                Console.WriteLine(usersList[0]);
            }
            //  TODO:  else throw here ?

        }


    }
}
