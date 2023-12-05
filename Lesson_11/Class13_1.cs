using System;

namespace Task1
{
    public enum AccountType
    {
        Checking,
        Savings
    }

    public class BankAccount
    {
        private string accountNumber;
        private decimal balance;
        private AccountType accountType;
        private string accountHolder;

        public BankAccount(string accountNumber, decimal balance, AccountType accountType, string accountHolder)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.accountType = accountType;
            this.accountHolder = accountHolder;
        }

        public string AccountNumber
        {
            get { return accountNumber; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public AccountType AccountType
        {
            get { return accountType; }
        }

        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }
    }

    public class BankTransaction
    {
        private readonly decimal amount;
        private readonly DateTime transactionDate;

        public BankTransaction(decimal amount)
        {
            this.amount = amount;
            this.transactionDate = DateTime.Now;
        }

        public decimal Amount
        {
            get { return amount; }
        }

        public DateTime TransactionDate
        {
            get { return transactionDate; }
        }
    }
}
