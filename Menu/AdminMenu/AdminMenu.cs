using GarbageCollectorStore.Managers.ProductManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorStore
{
    internal static class AdminMenu
    {
        public static void MenuAdmin()
        {
            while (true)
            {
                Console.WriteLine(TextColor.MenuText("Admin Menu:"));
                Console.WriteLine(TextColor.MenuText("1. Add Product"));
                Console.WriteLine(TextColor.MenuText("2. Remove Product"));
                Console.WriteLine(TextColor.MenuText("3. View All Products"));
                Console.WriteLine(TextColor.MenuText("4. View All Users"));
                Console.WriteLine(TextColor.MenuText("0. Logout"));
                string choice = Console.ReadLine();
                switch (choice)
                {
                //      Администратор:
                //  -Управление товарами(добавление, редактирование, удаление, кол - во и тд)
                //  - просматривать список зарегистрированных пользователей.
                    case "1":
                        // TODO: AddProduct();
                        break;
                    case "2":
                        // TODO: RemoveProduct();
                        break;
                    case "3":
                        // TODO: ViewAllProducts();
                        ProductManager.ShowList();
                        break;
                    case "4":
                        // TODO: ViewAllUsers();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine(TextColor.ErrorText("Invalid option. Please try again."));
                        continue;
                }
            }
        }
        
    }
}
