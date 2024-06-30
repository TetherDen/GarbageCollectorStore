using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorStore.Managers.ProductManager
{
    internal class ProductManager
    {
        private List<Product> productList = new List<Product>();

        public void AddProduct(Product product)
        {
            productList.Add(product);
        }
        public void RemoveProduct(Product product)  //  Add remove by GUID ?
        {
            productList.Remove(product);
        }
        public void RemoveProduct(Guid productId)
        {
            var product = productList.Find(p => p.Id == productId);
            if (product != null)
            {
                productList.Remove(product);
            }
        }
        public void RemoveProduct(string productId)
        {
            if (Guid.TryParse(productId, out Guid parsedId))
            {
                RemoveProduct(parsedId);
            }
            //  add else  throw ?
        }

        public Product GetProduct(Guid productId)
        {
            return productList.Find(p => p.Id == productId);
        }

        public List<Product> GetProdList()
        {
            return productList;
        }

        public void Clear()
        {
            productList.Clear();
        }
        public void ShowList()
        {
            foreach (var item in productList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
