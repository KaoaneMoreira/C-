using System;
using System.Globalization;
using Exceçoes.Entities.Exceptions;
using Exceçoes.Entities;

namespace Exceçoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine());

            Account account = new Account(number, holder, balance, withdrawLimit);

            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine());
            try
            {
                account.Withdraw(amount);
                Console.WriteLine("New balance: " + account.Balance.ToString("f2", CultureInfo.InvariantCulture));
            }
            catch (Exception e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }



        }
    }
}
