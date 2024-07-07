using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorStore
{
    internal static class ReviewMenu
    {
        public static void MenuReview()
        {
            while (true)
            {
                Console.WriteLine(TextColor.MenuText("Reviews: "));
                Console.WriteLine(TextColor.MenuText("1. Read New Reviews"));
                Console.WriteLine(TextColor.MenuText("2. Read All Reviews"));
                Console.WriteLine(TextColor.MenuText("3. Clear All Reviews"));
                Console.WriteLine(TextColor.MenuText("0. Back"));
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Review.ReadNewReviews();
                        break;
                    case "2":
                        Review.ReadAllReviews();
                        break;
                    case "3":
                        Review.ClearReviews();
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
