using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorStore
{
    internal class Electronics : Product
    {
        public string Type {  get; set; }
        public string Model { get; set; }

        public Electronics(string type, string model,string name, decimal price, int quantity, string description  ) 
            : base (name,price, quantity, description)
        {
            Type = type;
            Model = model;
        }


        public override string ToString()
        {
            return $"Name: {Name}.  Brand: {Type}.  Model: {Model}.\nPrice: {Price}.  Quantity: {Quantity}\nDescrition: {Description}\nID: {Id}\n";
        }
    }
}
