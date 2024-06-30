using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorStore
{
    public static class Config
    {
        public const int MIN_LOGIN_LENGTH = 4;
        public const int MIN_PASSWORD_LENGTH = 5;
        public static string SuccessfulText(string text)
        {
            return $"\x1b[32m{text}\x1b[0m";
        }

        public static string ErrorText(string text)
        {
            return $"\x1b[91m{text}\x1b[0m";
        }

    }
}
