using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAccount = Bank.CreateAccount("My checking", 
                "test@test.com",
                TypeOfAccounts.Savings, 100);
            Console.WriteLine($"AN: {myAccount.AccountNumber}, Balance: {myAccount.Balance}, CD: {myAccount.CreatedDate}, AT: {myAccount.AccountType}, EA: {myAccount.EmailAddress}");

        }
    }
}
