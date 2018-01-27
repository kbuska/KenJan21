using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = Bank.CreateAccount("test@test.com", AccountType.Checking, 0.0M);

            Console.WriteLine($"AN: {account.AccountNumber}, TAA: {account.TypeOfAccount}, Balance: {account.Balance:C}, EA: {account.EmailAddress}");

            var account2 = Bank.CreateAccount("test2@test.com", initialBalance: 201.10M);
           
            Console.WriteLine($"AN: {account2.AccountNumber}, TAA: {account2.TypeOfAccount}, Balance: {account2.Balance:C}, EA: {account2.EmailAddress}");

            var account3 = Bank.CreateAccount("test3@test.com", AccountType.Savings);

            Console.WriteLine($"AN: {account3.AccountNumber}, TAA: {account3.TypeOfAccount}, Balance: {account3.Balance:C}, EA: {account3.EmailAddress}");
        }
    }
}
