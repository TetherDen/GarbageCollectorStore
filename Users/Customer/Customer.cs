using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorStore.Users.Customer
{
    internal class Customer : User
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public Customer (string login, string password) : base(login, password)
        {

        }
        public Customer (string login, string password,string name, string address, string email) : base(login, password)
        {
            Name = name;
            Address = address;
            Email = email;
        }



        public override string ToString()
        {
            return $"TODO: Customer ToString()";  // TODO:
        }
    }
}
