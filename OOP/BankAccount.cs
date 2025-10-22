using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class BankAccount
    {
        private string owner;
        private int balance;

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        public int Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("Сумма должна быть не меньше 0!");
                }
            }
        }

        public BankAccount(string owner, int balance)
        {
            this.owner = owner;
            this.Balance = balance;
        }

        public void Deposit(int sum)
        {
            if(sum >= 0)
            {
                balance += sum;
            }
            else
            {
                Console.WriteLine("Сумма депозита должна быть не меньше 0!");
            }
            Console.WriteLine($"{owner}, баланс: {balance}.");
        }
        public void Withdraw(int sum)
        {
            if (sum > balance)
            {
                Console.WriteLine("Недостаточно средств!");
            }
            else if (sum <= 0)
            {
                Console.WriteLine("Сумма должна быть больше 0!");
            }
            else
            {
                balance -= sum;
            }
            Console.WriteLine($"{owner}, баланс: {balance}.");
        }
    }
}
