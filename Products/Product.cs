using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorStore.Products
{
    internal abstract class Product
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; set; }
        //  public string Type { get; set; }   // Type наследникам ?
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
