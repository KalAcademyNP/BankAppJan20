using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
           var myAccount  = new Account();
           // myAccount.AccountNumber = 123456;
            myAccount.AccountName = "My checking";
            //myAccount.Balance = 1000000000000000;
            myAccount.Deposit(1001);
            Console.WriteLine($"AN: {myAccount.AccountNumber}, Balance: {myAccount.Balance}, CD: {myAccount.CreatedDate}");

            var myAccount2 = new Account();
            Console.WriteLine($"AN: {myAccount2.AccountNumber}, Balance: {myAccount2.Balance}, CD: {myAccount2.CreatedDate}");
        }
    }
}
