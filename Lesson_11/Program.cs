using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 13.1. Банк.");
            BankAccount account = new BankAccount("1337228", 1337228.00m, AccountType.Checking, "Michael");

            account.Balance = 2281337.00m;
            account.AccountHolder = "Franklin";

            Console.WriteLine("Account Number: " + account.AccountNumber);
            Console.WriteLine("Balance: " + account.Balance.ToString("C"));
            Console.WriteLine("Account Type: " + account.AccountType);
            Console.WriteLine("Account Holder: " + account.AccountHolder);

            Console.ReadKey();
            Console.Clear();
        }
    }
}

namespace Task2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Упражнение 13.2. Банк.");
            string accountNumber = Creator.CreateAccount("1337228", 1337228.00m, AccountType.Checking);
            BankAccount account = Creator.GetAccount(accountNumber);

            account.AddTransaction(new BankTransaction(1337.00m));
            account.AddTransaction(new BankTransaction(-343351.00m));

            Console.WriteLine("Account Number: " + account.AccountNumber);
            Console.WriteLine("Balance: " + account.Balance.ToString("C"));
            Console.WriteLine("Account Type: " + account.AccountType);

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Transaction {i + 1}: {account[i].Amount.ToString("C")} on {account[i].TransactionDate}");
            }

            Creator.RemoveAccount(accountNumber);

            Console.ReadKey();
            Console.Clear();
        }
    }

}
namespace Task_14_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Упражнение 14.1. DumbtoScreen");
            BankAccount account = new BankAccount("1337228", 1337228.00m, AccountType.Checking, "Travor");

            account.Balance = 2281337.00m;
            account.AccountHolder = "Franklin";

            account.DumpToScreen();

            Console.ReadKey();
            Console.Clear();
        }
    }

}