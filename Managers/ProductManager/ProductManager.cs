using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorStore.Managers.ProductManager
{
    internal static class ProductManager  // static ?
    {
        private static List<Product> productList = new List<Product>();

        public static void AddProduct(Product product)
        {
            productList.Add(product);
        }
        public static void RemoveProduct(Product product)  //  Add remove by GUID ?
        {
            productList.Remove(product);
        }
        public static void RemoveProduct(Guid productId)
        {
            var product = productList.Find(p => p.Id == productId);
            if (product != null)
            {
                productList.Remove(product);
            }
        }
        public static void RemoveProduct(string productId)
        {
            if (Guid.TryParse(productId, out Guid parsedId))
            {
                RemoveProduct(parsedId);
            }
            //  add else  throw ?
        }

        public static Product GetProduct(Guid productId)
        {
            return productList.Find(p => p.Id == productId);
        }

        public static List<Product> GetProdList()
        {
            return productList;
        }

        public static void Clear()
        {
            productList.Clear();
        }
        public static void ShowList()
        {
            foreach (var item in productList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
