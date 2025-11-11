using System;

namespace Pract13
{
    class Task2
    {
        static void Main(string[] args)
        {
            
        }
    }
    class BankAccount
    {
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string Owner { get; set; }
        public BankAccount(int accountNumber, decimal balance, string owner)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            Owner = owner;
        }
    }
    class CheckingAccount : BankAccount
    {
        public decimal OverdraftLimit { get; set; }
        public CheckingAccount(int accountNumber, decimal balance, string owner, decimal overdraftLimit) : base (accountNumber, balance, owner)
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
        public SavingAccount(int accountNumber, decimal balance, string owner, decimal interestRate) : base(accountNumber, balance, owner)
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
        public CreditAccount(int accountNumber, decimal balance, string owner, decimal creditLimit, string maturityDate) : base(accountNumber, balance, owner)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            Owner = owner;
            CreditLimit = creditLimit;
            MaturityDate = maturityDate;
        }
    }
}
