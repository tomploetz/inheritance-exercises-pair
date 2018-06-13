using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankTellerExercise.Classes;

namespace BankTellerExercise
{
    class Program
    {
        static void Main(string[] args)
        {
			BankCustomer testCust = new BankCustomer();
			BankAccount test = new BankAccount();
			CheckingAccount testCheck = new CheckingAccount();
			SavingsAccount testSave = new SavingsAccount();
			testCust.AddAccount(test);
			testCust.AddAccount(testCheck);
			testCust.AddAccount(testSave);

			testCheck.Deposit(24000);
			testSave.Deposit(1000);
			
			Console.WriteLine(testCust.Name + "VIP Status: " + testCust.IsVIP);

			Console.WriteLine("Total Account Balance: " + testCust.sum.ToString("c"));

			Console.ReadKey();
		}
    }
}
