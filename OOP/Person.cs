using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get{ return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if(value >= 0 && value <= 120)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Возраст должен быть от 0 до 120!");
                }
            }
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.Age = age;
        }

        public void SayHello()
        {
            Console.WriteLine($"Привет, я {name}, мне {age} лет!");
        }
    }
}
