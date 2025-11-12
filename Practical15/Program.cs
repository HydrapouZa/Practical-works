using System;

namespace Pract15
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot droid = new Robot("Droid-0749");
            IWorkable workable = droid;
            IRechargeable rechargeable = droid;
            workable.Work();
            workable.Work();
            rechargeable.Recharge();
            workable.Work();

            Lamp lamp = new Lamp();
            Fan fan = new Fan();
            IEnable lampEnable = lamp;
            IEnable fanEnable = fan;
            lampEnable.Enable(true);
            lampEnable.Enable(false);
            fanEnable.Enable(true);
            fanEnable.Enable(false);
            ISetLevel lampLevel = lamp;
            lampLevel.SetLevel(30);
            Console.ReadKey();
        }
    }

    // Задание 1

    interface IWorkable { void Work(); }

    interface IRechargeable { void Recharge(); }

    class Robot : IWorkable, IRechargeable
    {
        private string name;

        public int Energy { get; set; }

        public Robot(string name)
        {
            this.name = name;
            Energy = 100;
        }

        public void Work()
        {

            if (Energy > 0) { Energy -= 20; Console.WriteLine($"{name} работает. Энергия: {Energy}%"); }
            else Console.WriteLine("Недостаточно энергии для работы!");
        }

        public void Recharge()

        {
            Energy += 50;
            if (Energy > 100) Energy = 100;
            Console.WriteLine($"{name} заряжается. Энергия: {Energy}%");

        }
    }

    // Задание 2

    interface IEnable { void Enable(bool enable); }
    interface ISetLevel { void SetLevel(int level); }

    class Lamp : IEnable, ISetLevel
    {
        private int level = 0;
        public int Level
        {
            get { return level; }
            set
            {
                level = value;
                if (value > 100) Level = 100;
                else if (value < 0) Level = 0;
            } 
        }
        public void Enable(bool enable) 
        {
            if (enable) { Level = 100; Console.WriteLine("Лампа включена. Мощность: " + Level); }
            else { Level = 0; Console.WriteLine("Лампа выключена. Мощность: " + Level); }
        } 
        public void SetLevel(int _level) { Level = _level; Console.WriteLine("Мощность лампы изменилась на " + Level); }
    }
    class Fan : IEnable
    {
        public bool Enabled { get; set;}
        public void Enable(bool enable)
        {
            Enabled = enable;
            if (Enabled) Console.WriteLine("Вентилятор включен");
            else Console.WriteLine("Вентилятор выключен");
        }
    }
    
    // задание 3
}
