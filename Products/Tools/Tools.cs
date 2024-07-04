﻿using System;
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

        public Tools(string type, string name, decimal price, int quantity, string description) 
            : base(name, price, quantity, description)
        {
            Type = type;
        }

        public override string ToString()
        {
            return $"Name: {Name}.  Brand: {Type}.  \nPrice: {Price}.  Quantity: {Quantity}\nDescrition: {Description}\nID: {Id}\n";
        }
    }
}
