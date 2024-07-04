using GarbageCollectorStore.Managers.ProductManager;
//using GarbageCollectorStore.Managers.UserManager;
//using GarbageCollectorStore.Users.Admin;
using GarbageCollectorStore.Users.Customer;


namespace GarbageCollectorStore
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Products Electronics,Tools,Clothing,Sports
            Product prod1 = new Electronics("laptop", "Acer", "Aspire", 699.99, 5, "15.6 IPS (1920x1080) / Intel Core i5-12450H / RAM 16 / SSD 512");
            Product prod2 = new Tools("showel", "Showelator", 45.45, 10, "Multifunctional shovel");
            Product prod3 = new Clothing("cotton", "tshirt", 25.25, 20, "tshirtdesctription", "M", "S", "L", "XL");
            Product prod4 = new Sports("bike", "Hyper", 77.77, 3, "goodbike");

            // Prod Manager
            ProductManager.AddProduct(prod1);   // mb make overload +-
            ProductManager.AddProduct(prod2);   // как будет адд в меню? guid или Obj, или в методе show юзеру давать фейк id 1,2,3,4 ?
            ProductManager.AddProduct(prod3); //  add by id ( guid ) ?  ( сейчас obj ) 
            ProductManager.AddProduct(prod4);


            Menu.MainMenu();  //  Text_color_of_message вынести в отдельный класс ?

            //Manager.ShowList();
            ProductManager.RemoveProduct(prod3);
            //Manager.RemoveProduct("74e3527d-3d96-4689-a4ff-f1f60292037a");  // ff guid  // на каждом запуске новый guid, пока-что
            ProductManager.RemoveProduct(prod4.Id);  // пока так,  guid в ID
            ProductManager.ShowList();


            /*UserManager userManager = new UserManager(); */ // TODO: ViewRegisteredUsers()
/*            UserManager.ShowAdmin();   *///  admin should not have method to show ?
            

            //Console.Write(userManager.isAdminRegistered());
            // TODO: Customer:  override ToString();
        }
    }
}
