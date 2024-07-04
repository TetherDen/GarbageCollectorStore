using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorStore
{
    internal class Clothing : Product
    {
        public string Material {  get; set; }
        public List<string> Sizes { get; set; }

        public Clothing(string material, string name, decimal price, int quantity, string description, List<string> sizes)
            : base(name, price, quantity, description)
        {
            Material = material;
            Sizes = new List<string>(sizes);
        }
        public Clothing(string material, string name, decimal price, int quantity, string description, params string[]  sizes)
    : base(name, price, quantity, description)
        {
            Material = material;
            Sizes = new List<string>(sizes);
        }

        public override string ToString()
        {
            string sizesString = string.Join(", ", Sizes.Select(s => s.ToString()));
            return $"Name: {Name}.  Material: {Material}.  Sizes: {sizesString}.\nPrice: {Price}.  Quantity: {Quantity}\nDescrition: {Description}\nID: {Id}\n";
        }
    }
}
