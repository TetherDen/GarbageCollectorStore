using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorStore
{
    internal abstract class User
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Login { get; set; }
        public string Password { get; set; }

        protected User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        //public abstract void Register();
    }
}
