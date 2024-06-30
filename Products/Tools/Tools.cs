using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorStore
{
    internal class Tools : Product
    {
        public string Type { get; set; }

        public Tools(string type, string name, double price, int quantity, string description) 
            : base(name, (decimal)price, quantity, description)
        {
            Type = type;
        }

        public override string ToString()
        {
            return $"ID: {Id}\nName: {Name}.  Brand: {Type}.  \nPrice: {Price}.  Quantity: {Quantity}\nDescrition: {Description}\n";
        }
    }
}
