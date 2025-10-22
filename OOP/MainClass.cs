using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Person man = new Person("Артём", 17);
            man.SayHello();
            Phone samsung = new Phone("Samsung", 80);
            samsung.UsePhone();
            samsung.UsePhone();
            BankAccount account = new BankAccount("Иван", 500);
            account.Deposit(500);
            account.Withdraw(750);
            account.Withdraw(500);
            Circle circle = new Circle(2);
            circle.GetArea();
            Pet rex = new Pet("Рекс", 80);
            rex.Play();
            rex.Rest();
            Console.ReadKey();
        }
    }
}
