using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorStore
{
    internal static class Logger
    {
        private static readonly NLog.Logger logger = LogManager.GetCurrentClassLogger();
        public static void LogProgramStart()
        {
            string ipAddress = GetExternalIPAddress();
            logger.Info($"Program started from {ipAddress}");
        }

        private static string GetExternalIPAddress()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string externalIP = client.DownloadString("http://icanhazip.com").Trim();
                    return externalIP;
                }
            }
            catch (Exception ex)
            {
                return $"Unable to get external IP: {ex.Message}";
            }
        }

    }
}
