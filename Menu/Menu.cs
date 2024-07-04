using GarbageCollectorStore.Managers.RegistrationManager;
using System;
using System.Collections.Generic;
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
                Console.WriteLine("     Admin registration required");
                // TODO:  Admin Registretion
                // Globaol Pointer?
                UserManager.CurrentUser = RegistrationManager.AdminRegister();
                if (UserManager.CurrentUser != null)
                {
                    Console.WriteLine(TextColor.SuccessfulText("You have successfully registered."));
                }
            }

            while(true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
                Console.WriteLine("0. Exit");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        {
                            // TODO: Login()
                            //TODO Admin/Customer MENU
                            UserManager.CurrentUser = UserManager.Login();
                            break;
                        }
                    case "2":
                        {
                            // TODO: Register();
                            Console.WriteLine("Creating an account");
                            //Config.CurrentUser = UserManager.CustomerRegister();
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
