//using NLog;
//using Newtonsoft.Json;
using System.Net;
namespace GarbageCollectorStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Products Electronics,Tools,Clothing,Sports
            //Product prod1 = new Electronics("laptop", "Acer", "Aspire",699.99m, 5, "15.6 IPS (1920x1080) / Intel Core i5-12450H / RAM 16 / SSD 512");
            //Product prod2 = new Tools("showel", "Showelator", 45.45m, 10, "Multifunctional shovel");
            //Product prod3 = new Clothing("cotton", "tshirt", 25.25m, 20, "tshirtdesctription", "M", "S", "L", "XL");
            //Product prod4 = new Sports("bike", "Hyper", 77.77m, 3, "goodbike");

            //// Prod Manager   //
            //ProductManager.AddProduct(prod1);
            //ProductManager.AddProduct(prod2);
            //ProductManager.AddProduct(prod3);
            //ProductManager.AddProduct(prod4);

            //FileManager.LoadUsers();
            //FileManager.LoadProducts();    // 
            //FileManager.LoadReviews();
            //Menu.MainMenu(); 
            //FileManager.SaveUsers();
            //FileManager.SaveProducts();
            //FileManager.SaveReviews();

            Starter.StartProgram();




            //ProductManager.ShowList();  // У продуктов ToString надо сделать красиво

            /*UserManager userManager = new UserManager(); */ // TODO: ViewRegisteredUsers()
/*            UserManager.ShowAdmin();   *///  admin should not have method to show hes log/pass?
            
            // TODO: Customer:  override ToString();
        }
    }
}

