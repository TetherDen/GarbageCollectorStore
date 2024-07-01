using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorStore
{
    internal class Admin : User
    {
        public Admin(string login, string password):base(login, password)
        {
        }

        public override string ToString()
        {
            return $"Login: {Login}, Password: {Password}\n";
        }

    }
}
