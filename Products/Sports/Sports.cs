using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorStore
{
    internal class Sports : Product
    {
        public string Type { get; set; }

        public Sports() { }
        public Sports(string type, string name, decimal price, int quantity, string description)
            : base(name, price, quantity, description)
        {
            Type = type;
        }
        public Sports(Sports other)
            : base(other.Name, other.Price, other.Quantity, other.Description)
        {
            Type = other.Type;
        }
        public override Product Clone()
        {
            return new Sports(this);
        }

        public override string ToString()
        {
            return $"Name: {Name}.  Brand: {Type}.\nPrice: {Price}.  Quantity: {Quantity}\nDescrition: {Description}\n";
            //return $"Name: {Name}.  Brand: {Type}.\nPrice: {Price}.  Quantity: {Quantity}\nDescrition: {Description}\nID: {Id}\n";
        }
    }
}
