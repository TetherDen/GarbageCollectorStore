using GarbageCollectorStore.Managers.RegistrationManager;
using GarbageCollectorStore.Users.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorStore
{
    internal static class Menu
    {
        public static void MainMenu()
        {
            if (!RegistrationManager.isAdminRegistered())
            {
                Console.WriteLine(TextColor.MenuText("     Admin registration required!"));
                UserManager.CurrentUser = RegistrationManager.AdminRegister();
                if (UserManager.CurrentUser != null)
                {
                    Console.WriteLine(TextColor.SuccessfulText("Admin have successfully registered."));
                }
            }

            while(true)
            {
                Console.WriteLine(TextColor.MenuText("Select an option:"));
                Console.WriteLine(TextColor.MenuText("1. Login"));
                Console.WriteLine(TextColor.MenuText("2. Register"));
                Console.WriteLine(TextColor.MenuText("0. Exit"));
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        {                        
                            UserManager.CurrentUser = UserManager.Login();
                            if(UserManager.CurrentUser != null)
                            {
                                if(UserManager.CurrentUser is Admin)
                                {
                                    AdminMenu.MenuAdmin();
                                }
                                else if(UserManager.CurrentUser is Customer)
                                {
                                    CustomerMenu.MenuCustomer();
                                }
                                
                            }
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Creating an account");
                            UserManager.CurrentUser = RegistrationManager.CustomerRegister();
                            if (UserManager.CurrentUser != null)
                            {
                                Console.WriteLine(TextColor.SuccessfulText("You have successfully registered."));
                            }
                            break;
                        }
                    case "0":
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine(TextColor.ErrorText("Invalid option. Please try again."));
                            continue;
                        }
                }
            }
        }
    }
}
