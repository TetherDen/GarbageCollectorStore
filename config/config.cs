using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorStore
{
    internal static class Config
    {
        public const string STORE_NAME = "Garbage Collector Store";

        public const int MIN_LOGIN_LENGTH = 4;
        public const int MIN_PASSWORD_LENGTH = 5;
        // Customer
        public const int MIN_NAME_LENGTH = 3;
        public const int MIN_ADDRESS_LENGTH = 3;
        public const string EMAIL_REGEX = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"+ "@"+ @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";

        // Users File/Dir Pathes
        public const string usersPathToDir = "../../../data/";  // для папки 
        public static readonly string usersPathToFile = Path.Combine(usersPathToDir, "users.bin");  // для файла
        // Products File/Dir Pathes
        public const string productsPathToDir = "../../../data/";
        public static readonly string ProductsPathToFile = Path.Combine(productsPathToDir, "products.json");


    }
}
