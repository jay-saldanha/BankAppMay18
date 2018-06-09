using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //object or instance of a class, instantiation
            var account = new Account();
            account.AccountNumber = 12345;
            account.EmailAddress = "test@test.com";
            //account.TypeOfAccount = "Checking";
            //account.Balance = 1000000;
            Console.WriteLine($"AN: {account.AccountNumber}, Balance: {account.Balance}, EA:{account.EmailAddress},TA: {account.TypeOfAccount}, CA: {account.CreatedDate}");
            var account2 = new Account();
            account2.AccountNumber = 12345;
            account2.EmailAddress = "test@test.com";
            //account.TypeOfAccount = "Checking";

        }
    }
}
