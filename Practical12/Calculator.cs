using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac12
{
    class Calculator
    {
        public static float Addition(float a, float b)
        {
            return a + b;
        }
        public static float Substraction(float a, float b)
        {
            return a - b;
        }
        public static float Division(float a, float b)
        {
            if(b == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль!");
                return 0;
            }
            else return a / b;
        }
        public static float Multiplication(float a, float b)
        {
            return a * b;
        }
    }
}
