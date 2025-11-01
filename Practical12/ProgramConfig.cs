using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac12
{
    class ProgramConfig
    {
        private const string version = "1.0";
        private const string developerName = "Ermolaev Kirill";
        public static void ShowProgramInfo()
        {
            Console.WriteLine("Версия программы: " + version + ", разработчик: " + developerName);
        }
    }
}
