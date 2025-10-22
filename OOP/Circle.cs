using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Circle
    {
        private float radius;

        public float Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    Console.WriteLine("Радиус должен быть больше 0!");
                }
            }
        }

        public Circle(float radius)
        {
            this.Radius = radius;
        }

        public void GetArea()
        {
            Console.WriteLine("Площадь круга: " + Math.PI * Math.Pow(radius, 2));
        }
    }
}
