using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_1
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
        private string accountHolder;
        private List<BankTransaction> transactions = new List<BankTransaction>();

        internal BankAccount(string accountNumber, decimal balance, AccountType accountType, string accountHolder)
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

        public BankTransaction this[int index]
        {
            get { return transactions[index]; }
        }

        public void AddTransaction(BankTransaction transaction)
        {
            transactions.Add(transaction);
        }

        [System.Diagnostics.Conditional("DEBUG_ACCOUNT")]
        public void DumpToScreen()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Balance: {Balance}");
            Console.WriteLine($"Account Type: {AccountType}");
            Console.WriteLine($"Account Holder: {AccountHolder}");
        }
    }

}
