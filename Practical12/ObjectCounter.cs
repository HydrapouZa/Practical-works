using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac12
{
    class ObjectCounter
    {
        private static int objectsCount;

        public ObjectCounter()
        {
            objectsCount++;
        }
        public static void COutObjectsCount()
        {
            Console.WriteLine("Количество экземпляров этого класса: " + objectsCount);
        }
    }
}
