using GarbageCollectorStore.Users.Admin;
using GarbageCollectorStore.Users.Customer;

namespace GarbageCollectorStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin("admin", "admin");

            Product prod1 = new Electronics("laptop", "Acer", "Aspire", 699.99, 5, "15.6 IPS (1920x1080) / Intel Core i5-12450H / RAM 16 / SSD 512");
            Console.WriteLine(prod1);

            Product prod2 = new Tools("showel", "Showelator", 45.45, 10, "Multifunctional shovel");
            Console.WriteLine(prod2);

            Product prod3 = new Clothing("cotton", "tshirt", 25.25, 20, "tshirtdesctription", "M", "S", "L", "XL");
            Console.WriteLine(prod3);

            Product prod4 = new Sports("bike", "Hypercycle", 77.77, 3, "goodbike");

        }
    }
}
