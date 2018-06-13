using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests.Classes
{
	[TestClass]
	public class BankCustomerTests
	{
		[TestMethod]
		public void IsVIP()
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

			Assert.AreEqual(true, testCust.IsVIP, "26000 combined, should be VIP" );





			BankCustomer testCust1 = new BankCustomer();
			BankAccount test1 = new BankAccount();
			CheckingAccount testCheck1 = new CheckingAccount();
			SavingsAccount testSave1 = new SavingsAccount();
			testCust1.AddAccount(test1);
			testCust1.AddAccount(testCheck1);
			testCust1.AddAccount(testSave1);

			testCheck1.Deposit(2000);
			testSave1.Deposit(1000);

			Assert.AreEqual(false, testCust1.IsVIP, "3000 combined, shouldnt be VIP");
		}
	}
}
