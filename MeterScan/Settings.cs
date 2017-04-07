using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MeterScan
{
    class Settings
    {
        public static string SSIDName;
        public static string IPAddress;
        public static string Port;
        public static string Password;
        public static bool IsEmpty()
        {
            string path = "\\settings.txt";
            return !File.Exists(path);            
        }
    }
}
