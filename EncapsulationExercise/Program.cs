using System;

namespace EncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine($"Enter the amount of you like to deposit:");
            var amountDeposit = double.Parse(Console.ReadLine());
            account.Deposit(amountDeposit);
            Console.WriteLine($"Your available deposit amount is:{account.GetBalance()}");
            //account.Balance = 1000;


            Console.WriteLine(account.Balance);
        }
    }
}
