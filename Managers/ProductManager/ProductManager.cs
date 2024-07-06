using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorStore
{
    internal static class ProductManager 
    {
        private static List<Product> _productList = new List<Product>();
        public static List<Product> ProductList { get { return _productList; } set { _productList = value; } }

        public static void AddProductChoice()
        {
            while (true)
            {
                Console.WriteLine(TextColor.MenuText("Select a product type to add:"));
                Console.WriteLine(TextColor.MenuText("1. Clothing"));
                Console.WriteLine(TextColor.MenuText("2. Electronics"));
                Console.WriteLine(TextColor.MenuText("3. Sports"));
                Console.WriteLine(TextColor.MenuText("4. Tools"));
                Console.WriteLine(TextColor.MenuText("0. Back to Main Menu"));

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddClothing();
                        break;
                    case "2":
                        AddElectronics();
                        break;
                    case "3":
                        AddSports();
                        break;
                    case "4":
                        AddTools();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine(TextColor.ErrorText("Invalid option. Please try again."));
                        break;
                }
            }
        }
        public static void AddProduct(Product product)     // TODO: private
        {
            _productList.Add(product);
        }
        private static bool IsProductAdded(Product product)   // Проверка добавлен ли продукт в список
        {
            if (_productList.Any(p => p.Id == product.Id))
            {
                Console.WriteLine(TextColor.SuccessfulText($"'{product.Name}' has been successfully added."));
                return true;
            }
            else
            {
                Console.WriteLine(TextColor.ErrorText("Failed to add product. Please try again."));
                return false;
            }
        }
        private static void ProductDetails(out string name, out decimal price, out int quantity, out string description)  // Запрос данных абстрактного класс Продукт
        {
            Console.WriteLine(TextColor.RequestText("Enter product name:"));
            name = Console.ReadLine();
            Console.WriteLine(TextColor.RequestText("Enter price:"));
            while (!decimal.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine(TextColor.ErrorText("Invalid price format. Please enter a valid number:"));
            }
            Console.WriteLine(TextColor.RequestText("Enter quantity:"));
            while (!int.TryParse(Console.ReadLine(), out quantity))
            {
                Console.WriteLine(TextColor.ErrorText("Invalid quantity format. Please enter a valid number:"));
            }
            Console.WriteLine(TextColor.RequestText("Enter description:"));
            description = Console.ReadLine();
        }
        private static void AddClothing()
        {
            string name, description;
            decimal price;
            int quantity;
            ProductDetails(out name, out price, out quantity, out description);
            Console.WriteLine(TextColor.RequestText("Enter material:"));
            string material = Console.ReadLine();
            Console.WriteLine(TextColor.RequestText("Enter sizes (comma-separated):"));
            string sizesInput = Console.ReadLine();
            List<string> sizes = new List<string>(sizesInput.Split(','));
            Clothing clothing = new Clothing(material, name, price, quantity, description, sizes);
            AddProduct(clothing);
            IsProductAdded(clothing);
        }
        private static void AddElectronics()
        {
            string name, description, type, model;
            decimal price;
            int quantity;
            ProductDetails(out name, out price, out quantity, out description);
            Console.WriteLine(TextColor.RequestText("Enter type:"));
            type = Console.ReadLine();
            Console.WriteLine(TextColor.RequestText("Enter model:"));
            model = Console.ReadLine();
            Electronics electronics = new Electronics(type, model, name, price, quantity, description);
            AddProduct(electronics);
            IsProductAdded(electronics);
        }
        private static void AddSports()
        {
            string name, description, type;
            decimal price;
            int quantity;
            ProductDetails(out name, out price, out quantity, out description);
            Console.WriteLine(TextColor.RequestText("Enter sport type:"));
            type = Console.ReadLine();
            Sports sports = new Sports(type, name, price, quantity, description);
            AddProduct(sports);
            IsProductAdded(sports);
        }
        private static void AddTools()
        {
            string name, description, type;
            decimal price;
            int quantity;
            ProductDetails(out name, out price, out quantity, out description);
            Console.WriteLine(TextColor.RequestText("Enter tool type:"));
            type = Console.ReadLine();
            Tools tools = new Tools(type, name, price, quantity, description);
            AddProduct(tools);
            IsProductAdded(tools);
        }
        public static void RemoveProduct(Guid productId)
        {
            var product = _productList.Find(p => p.Id == productId);
            if (product != null)
            {
                _productList.Remove(product);
            }
        }   // not using ?
        public static void RemoveProduct(int index)   
        {
            if (index > 0 && index <= _productList.Count)
            {    
                Console.WriteLine(TextColor.SuccessfulText($" {_productList[index-1].Name}, {_productList[index - 1].Price} removed successfully."));
                _productList.RemoveAt(index - 1);
            }
            else
            {
                Console.WriteLine(TextColor.ErrorText("Invalid ID. Please enter a valid ID."));
            }

        }

        public static Product GetProduct(Guid productId)
        {
            return _productList.Find(p => p.Id == productId);
        }  // not used

        public static List<Product> GetProdList()
        {
            return _productList;
        }

        public static void Clear()
        {
            _productList.Clear();
        }
        public static void ShowList()   //
        {
            if(_productList.Count > 0)
            {
                int index = 1;
                foreach (var item in _productList)
                {
                    Console.Write($"{TextColor.MenuText($"ID {index}, ")}");
                    Console.WriteLine(item);
                    index++;
                }
            }
            else
            {
                Console.WriteLine(TextColor.InfoText("The product list is currently empty."));
            }
        }
    }
}
