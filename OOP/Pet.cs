using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Pet
    {
        private string name;
        private int energy;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Energy
        {
            get { return energy; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    energy = value;
                }
                else
                {
                    Console.WriteLine("Энергия должена быть от 0 до 100!");
                }
            }
        }

        public Pet(string name, int energy)
        {
            this.name = name;
            Energy = energy;
        }

        public void Play()
        {
            energy -= 20;
            if (energy <= 0)
            {
                energy = 0;
                Console.WriteLine($"{name} устал");
            }
            Console.WriteLine($"{name} играет, энергия: {energy}.");
        }
        public void Rest()
        {
            energy += 30;
            if (energy > 100)
            {
                energy = 100;
            }
            Console.WriteLine($"{name} отдыхает, энергия: {energy}.");
        }
    }
}
