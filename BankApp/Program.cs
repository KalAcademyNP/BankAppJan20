using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
           var myAccount  = new Account();
            myAccount.AccountNumber = 123456;
            myAccount.AccountName = "My checking";

            var myAccount2 = new Account();
            myAccount2.AccountNumber = 34567;

        }
    }
}
