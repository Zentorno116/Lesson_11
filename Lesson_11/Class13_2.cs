using System;

namespace Task2
{
    using System;
    using System.Collections.Generic;

    public enum AccountType
    {
        Checking,
        Savings
    }

    public class BankTransaction
    {
        public readonly decimal Amount;
        public readonly DateTime TransactionDate;

        public BankTransaction(decimal amount)
        {
            Amount = amount;
            TransactionDate = DateTime.Now;
        }
    }

    public class BankAccount
    {
        private string accountNumber;
        private decimal balance;
        private AccountType accountType;
        private List<BankTransaction> transactions = new List<BankTransaction>();

        internal BankAccount(string accountNumber, decimal balance, AccountType accountType)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.accountType = accountType;
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

        public BankTransaction this[int index]
        {
            get { return transactions[index]; }
        }

        public void AddTransaction(BankTransaction transaction)
        {
            transactions.Add(transaction);
        }
    }

    public class Creator
    {
        private static Dictionary<string, BankAccount> accounts = new Dictionary<string, BankAccount>();

        private Creator() { }

        public static string CreateAccount(string accountNumber, decimal balance, AccountType accountType)
        {
            var account = new BankAccount(accountNumber, balance, accountType);
            accounts.Add(accountNumber, account);
            return accountNumber;
        }

        public static void RemoveAccount(string accountNumber)
        {
            accounts.Remove(accountNumber);
        }

        public static BankAccount GetAccount(string accountNumber)
        {
            return accounts[accountNumber];
        }
    }

}