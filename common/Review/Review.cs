using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorStore.common.Review
{
    internal class Review
    {
        public string ReviewText { get; set; }
        public DateTime Date { get; } = DateTime.Now;
        public bool IsRead { get; set; } = false;
        public string UserLogin { get; set; }
        public static List<Review> AllReviews = new List<Review>();

        public Review(string reviewText, string userLogin)
        {
            ReviewText = reviewText;
            UserLogin = userLogin;  
        }

        public static void LeaveReview()
        {
            Console.WriteLine(TextColor.RequestText("Enter your review:"));
            string text = Console.ReadLine();
            AllReviews.Add(new Review(text, UserManager.CurrentUser.Login));
            Console.WriteLine(TextColor.SuccessfulText("Thank you for your review!"));
        }
        public static void ReadAllReviews()
        {
            Console.WriteLine(TextColor.MenuText("All Reviews:"));
            foreach (var review in Review.AllReviews)
            {
                Console.WriteLine($"{review.Date}, Customer: {review.UserLogin}\n{review.ReviewText}\n");
                review.IsRead = true;
            }
        }
        public static void ReadNewReviews()
        {
            Console.WriteLine(TextColor.MenuText("New Reviews:"));
            foreach (var review in Review.AllReviews)
            {
                if (!review.IsRead)
                {
                    Console.WriteLine($"{review.Date}, Customer: {review.UserLogin}\n{review.ReviewText}\n");
                    review.IsRead = true;
                }
            }
        }
        public static void ClearReviews()
        {
            AllReviews.Clear();
            Console.WriteLine(TextColor.SuccessfulText("All reviews have been cleared."));
        }




    }
}
