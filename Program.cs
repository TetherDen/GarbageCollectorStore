//using GarbageCollectorStore.Managers.ProductManager;
//using GarbageCollectorStore.Users.Customer;


namespace GarbageCollectorStore
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Products Electronics,Tools,Clothing,Sports
            Product prod1 = new Electronics("laptop", "Acer", "Aspire", (decimal)699.99, 5, "15.6 IPS (1920x1080) / Intel Core i5-12450H / RAM 16 / SSD 512");
            Product prod2 = new Tools("showel", "Showelator", (decimal)45.45, 10, "Multifunctional shovel");
            Product prod3 = new Clothing("cotton", "tshirt", (decimal)25.25, 20, "tshirtdesctription", "M", "S", "L", "XL");
            Product prod4 = new Sports("bike", "Hyper", (decimal)77.77, 3, "goodbike");

            // Prod Manager   //  TODO: after file system .AddProduct - make private method
            ProductManager.AddProduct(prod1);   // mb make overload +-
            ProductManager.AddProduct(prod2);
            ProductManager.AddProduct(prod3);
            ProductManager.AddProduct(prod4);

            FileManager.LoadUsers();
            Menu.MainMenu(); 
            FileManager.SaveUsers();
            ProductManager.ShowList();  // У продуктов ToString надо сделать красиво

            /*UserManager userManager = new UserManager(); */ // TODO: ViewRegisteredUsers()
/*            UserManager.ShowAdmin();   *///  admin should not have method to show ?
            
            // TODO: Customer:  override ToString();
        }
    }
}
