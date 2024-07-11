using GarbageCollectorStore.Users.Customer;
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
                Console.WriteLine(TextColor.MenuText("3. Remove product from the cart"));
                Console.WriteLine(TextColor.MenuText("4. View Cart"));
                Console.WriteLine(TextColor.MenuText("5. Checkout"));
                Console.WriteLine(TextColor.MenuText("6. Leave a Review"));
                Console.WriteLine(TextColor.MenuText("0. Logout"));
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ProductManager.ShowList();
                        break;
                    case "2":
                        (UserManager.CurrentUser as Customer).Cart.AddProductToCart();
                        break;
                    case "3":
                        if (UserManager.CurrentUser is Customer)
                        {
                            int index;
                            Console.WriteLine(TextColor.RequestText("Enter ID of the product to remove:"));
                            int.TryParse(Console.ReadLine(), out index);
                            (UserManager.CurrentUser as Customer).Cart.RemoveProductFromCart(index);
                        }
                        else
                        {
                            Console.WriteLine(TextColor.ErrorText("Invalid input. Please enter a valid ID."));
                        }
                        break;
                    case "4":
                        (UserManager.CurrentUser as Customer).Cart.ViewCart();
                        break;
                    case "5":
                        (UserManager.CurrentUser as Customer).Cart.Checkout();
                        break;
                    case "6":
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
