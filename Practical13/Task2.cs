using System;

namespace Pract13
{
    class Task2
    {
        static void Main(string[] args)
        {
            CheckingAccount acc = new CheckingAccount("4850098576488787", 2495, "Генадий", -1000);
            Console.WriteLine($"{acc.Owner} имеет на своём счету {acc.Balance} денег. Лимит овердфта: {acc.OverdraftLimit}");
            Console.ReadKey();
        }
    }
    class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string Owner { get; set; }
        public BankAccount(string accountNumber, decimal balance, string owner)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            Owner = owner;
        }
    }
    class CheckingAccount : BankAccount
    {
        public decimal OverdraftLimit { get; set; }
        public CheckingAccount(string accountNumber, decimal balance, string owner, decimal overdraftLimit) : base (accountNumber, balance, owner)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            Owner = owner;
            OverdraftLimit = overdraftLimit;
        }
    }
    class SavingAccount : BankAccount
    {
        public decimal InterestRate { get; set; }
        public SavingAccount(string accountNumber, decimal balance, string owner, decimal interestRate) : base(accountNumber, balance, owner)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            Owner = owner;
            InterestRate = interestRate;
        }
    }
    class CreditAccount : BankAccount
    {
        public string MaturityDate { get; set; }
        public decimal CreditLimit { get; set; }
        public CreditAccount(string accountNumber, decimal balance, string owner, decimal creditLimit, string maturityDate) : base(accountNumber, balance, owner)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            Owner = owner;
            CreditLimit = creditLimit;
            MaturityDate = maturityDate;
        }
    }
}
