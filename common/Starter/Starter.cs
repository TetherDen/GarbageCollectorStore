using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorStore
{
    internal static class Starter
    {
        public static void StartProgram()
        {
            Logger.LogProgramStart();
            FileManager.LoadUsers();
            FileManager.LoadProducts();  
            FileManager.LoadReviews();
            Menu.MainMenu();
            FileManager.SaveUsers();
            FileManager.SaveProducts();
            FileManager.SaveReviews();
        }
    }
}
