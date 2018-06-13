using System;
using BankTellerExercise.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTellerExerciseTests.Classes
{
	[TestClass]
	public class SavingAccountTests
	{
		[TestMethod]
		public void Withdraw()
		{
			SavingsAccount _savingsAccount = new SavingsAccount();
			_savingsAccount.Deposit(1000.00M);

			Assert.AreEqual(1000.00M, _savingsAccount.Withdraw(5000), "input" + ":Withdraw(5000.00M)");
			_savingsAccount.Withdraw(850.00M);
			Assert.AreEqual(147.00M, _savingsAccount.Withdraw(1), "input" + ":Withdraw(1.00M)");
		}
	}
}
