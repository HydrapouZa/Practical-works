using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Phone
    {
        private string brand;
        private int batteryLevel;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public int BatteryLevel
        {
            get { return batteryLevel; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    batteryLevel = value;
                }
                else
                {
                    Console.WriteLine("Заряд должен быть от 0 до 100!");
                }
            }
        }

        public Phone(string brand, int batteryLevel)
        {
            this.brand = brand;
            BatteryLevel = batteryLevel;
        }

        public void UsePhone()
        {
            batteryLevel -= 10;
            if(batteryLevel <= 0)
            {
                batteryLevel = 0;
                Console.WriteLine("Телефон сел");
            }
            Console.WriteLine($"Телефон {brand}, заряд: {batteryLevel}%.");
        }
    }
}
