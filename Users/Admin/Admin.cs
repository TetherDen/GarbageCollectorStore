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



        public void ViewRegisteredUsers()
        {
            // TODO: ViewRegisteredUsers()
        }


    }
}
