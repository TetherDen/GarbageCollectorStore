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
                // add metod clear ?
                //  add get id ?
                    case "1":
                        ProductManager.AddProductChoice();
                        break;
                    case "2":
                        Console.WriteLine(TextColor.RequestText("Enter ID of the product to remove:"));
                        if (int.TryParse(Console.ReadLine(), out int index))
                        {
                            ProductManager.RemoveProduct(index);
                        }
                        else
                        {
                            Console.WriteLine(TextColor.ErrorText("Invalid input. Please enter a valid ID."));
                        }
                        // TODO: RemoveProduct();
                        break;
                    case "3":
                        // TODO: ShowList  make better + colors? + change GUID ID on  fake ID
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
