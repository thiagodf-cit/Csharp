using System;
using BankAccount.Entities;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount businessAccount = new BusinessAccount(1234, "Thiago M.", 1500.00, 500.00);

            Console.WriteLine(businessAccount.Balance);
        }
    }
}
