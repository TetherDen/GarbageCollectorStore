using GarbageCollectorStore.common.Review;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorStore
{
    internal static class CustomerMenu
    {
        public static void MenuCustomer()
        {
            while (true)
            {
                Console.WriteLine(TextColor.MenuText("Customer Menu:"));
                Console.WriteLine(TextColor.MenuText("1. View Products"));
                Console.WriteLine(TextColor.MenuText("2. Add Product to Cart"));
                Console.WriteLine(TextColor.MenuText("3. View Cart"));
                Console.WriteLine(TextColor.MenuText("4. Checkout"));
                Console.WriteLine(TextColor.MenuText("5. Leave a Review"));
                Console.WriteLine(TextColor.MenuText("0. Logout"));
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ProductManager.ShowList();
                        break;
                    case "2":
                        // TODO: AddProductToCart();
                        break;
                    case "3":
                        // TODO: ViewCart();
                        break;
                    case "4":
                        // TODO: Checkout();
                        break;
                    case "5":
                        Review.LeaveReview();
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
