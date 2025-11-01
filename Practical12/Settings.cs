using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac12
{
    class Settings
    {
        private static readonly string configPath;
        static Settings()
        {
            configPath = "C:/Users/Me/source/repos/Prac12/App.config";
        }
        public static void COutPath()
        {
            Console.WriteLine(configPath);
        }
    }
}
