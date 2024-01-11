using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lab 1 Example 
/// Include here the authors:
/// Include here date/revisions:
/// Source:
/// </summary>
namespace AccountApp
{
    /// <summary>
    /// Constants definition
    /// </summary>
    static class Constants
    {
        public const decimal InitialChequing = 50.00m;
        public const decimal InitialSavings = 0.00m;
    }
    /// <summary>
    /// Console application
    /// Entering deposit amounts and displaying the balance 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Account accountChequing = new Account("Chequing", Constants.InitialChequing);
            Account accountSevings = new Account("Savings", Constants.InitialSavings);

            Console.WriteLine(
               $"{accountChequing.Type} balance: {accountChequing.Balance:C}");
            Console.WriteLine(
               $"{accountSevings.Type} balance: {accountSevings.Balance:C}");

            Console.Write("\nEnter deposit amount for your Chequing account: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine(
               $"adding {depositAmount:C} to account Chequing balance\n");
            accountChequing.Deposit(depositAmount); 


            Console.WriteLine(
               $"{accountChequing.Type} balance: {accountChequing.Balance:C}");
            Console.WriteLine(
               $"{accountSevings.Type} balance: {accountSevings.Balance:C}");


            Console.Write("\nEnter deposit amount for your Savings account: ");
            depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine(
               $"adding {depositAmount:C} to Savings balance\n");
            accountSevings.Deposit(depositAmount); 


            Console.WriteLine(
               $"{accountChequing.Type} balance: {accountChequing.Balance:C}");
            Console.WriteLine(
               $"{accountSevings.Type} balance: {accountSevings.Balance:C}");
            Console.ReadLine();
        }
    }
}
