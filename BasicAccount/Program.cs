using System;
using System.Globalization;
using BasicAccount.Entities;
using BasicAccount.Entities.Exceptions;

namespace BasicAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int accNumber = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string accHolder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double accBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double accWithdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(accNumber, accHolder, accBalance, accWithdrawLimit);

                Console.Write("\nEnter for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                acc.Withdraw(amount);

                Console.WriteLine("New balance: " + acc.Balance.ToString("F2"));
            }
            catch (AccountException e)
            {
                Console.WriteLine("Withdraw error: " + e);
            }
        }
    }
}
