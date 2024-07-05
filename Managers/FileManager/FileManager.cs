using GarbageCollectorStore.Users.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorStore
{
    internal static class FileManager
    {
        public static  void SaveUsers()
        {
            using (FileStream fs = new FileStream(Config.usersFilePath, FileMode.Create))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    foreach ( User user in UserManager.UsersList)
                    {
                        if(user is Customer)
                        {
                            bw.Write("Customer");
                        }
                        else if (user is Admin)
                        {
                            bw.Write("Admin");
                        }
                        bw.Write(user.Login);
                        bw.Write(user.Password);
                        if(user is Customer customer)
                        {
                            bw.Write(customer.Name);
                            bw.Write(customer.Address);
                            bw.Write(customer.Email);
                        }
                    }
                }
            }
        }



    }
}
