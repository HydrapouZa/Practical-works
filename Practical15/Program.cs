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

            Phone phone = new Phone(15000, 24);
            Laptop laptop = new Laptop(30000);
            IPrice laptopPrice = laptop;
            IPrice phonePrice = phone;
            IWarrantyPeriod phoneWarranty = phone;
            Console.WriteLine($"Цена телефона: {phonePrice.GetPrice()}. Гарантия: {phoneWarranty.GetWarrantyPeriodInMonths()} месяца.");
            Console.WriteLine($"Цена ноутбука: {laptopPrice.GetPrice()}.");

            Warrior warrior = new Warrior();
            IAttack warriorAttack = warrior;
            Wizard wizard = new Wizard();
            IAttack wizardAttack = wizard;
            IHeal wizardHeal = wizard;
            warriorAttack.Attack();
            wizardAttack.Attack();
            wizardHeal.Heal();

            BankAccount vasya = new BankAccount();
            IDepositOrWithdraw vasyaDep = vasya;
            ITransferToAnotherAccount vasyaTrans = vasya;
            vasyaDep.Deposit(7000);
            BankAccount petya = new BankAccount();
            IDepositOrWithdraw petyaDep = petya;
            petyaDep.Deposit(7000);
            vasyaTrans.Transfer(1500, petya);
            petyaDep.Withdraw(1000);
            Console.WriteLine("Баланс Васи: " + vasya.Balance);
            Console.WriteLine("Баланс Пети: " + petya.Balance);

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

    interface IPrice { int GetPrice(); }
    interface IWarrantyPeriod { int GetWarrantyPeriodInMonths(); }
    
    class Phone : IPrice, IWarrantyPeriod
    {
        public int Price { get; set; }
        public int WarrantyPeriodInMonths { get; set; }
        public Phone(int price, int warrantyPeriod)
        {
            Price = price;
            WarrantyPeriodInMonths = warrantyPeriod;
        }
        public int GetWarrantyPeriodInMonths() { return WarrantyPeriodInMonths; }
        public int GetPrice() { return Price; }
    }
    class Laptop : IPrice
    {
        public int Price { get; set; }
        public Laptop(int price)
        {
            Price = price;
        }
        public int GetPrice() { return Price; }
    }

    // Задание 4

    interface IAttack { void Attack(); }
    interface IHeal { void Heal(); }

    class Warrior : IAttack
    {
        public void Attack() => Console.WriteLine("Воин атакует");
    }
    class Wizard: IAttack, IHeal
    {
        public void Attack() => Console.WriteLine("Маг атакует");
        public void Heal() => Console.WriteLine("Маг лечит");
    }

    // Задание 5

    interface IDepositOrWithdraw { void Deposit(int sum); void Withdraw(int sum); }
    interface ITransferToAnotherAccount { void Transfer(int sum, BankAccount accToTransfer); }

    class BankAccount : IDepositOrWithdraw, ITransferToAnotherAccount
    {
        public decimal Balance { get; set; }

        public void Deposit(int sum)
        {
            if (sum <= 0) { Console.WriteLine("Сумма должна быть не меньше 0!"); return; }
            Balance += sum; 
        }
        public void Withdraw(int sum) 
        { 
            if(sum <= 0) { Console.WriteLine("Сумма должна быть не меньше 0!"); return; }
            if (sum <= Balance) Balance -= sum; 
            else Console.WriteLine("Недостаточно средств"); 
        }
        public void Transfer(int sum, BankAccount accToTransfer)
        {
            if (sum <= 0) { Console.WriteLine("Сумма должна быть не меньше 0!"); return; }
            if (sum <= Balance)
            {
                Balance -= sum;
                IDepositOrWithdraw Itrans = accToTransfer;
                Itrans.Deposit(sum);
            }
            else Console.WriteLine("Недостаточно средств"); 
        }
    }
}
