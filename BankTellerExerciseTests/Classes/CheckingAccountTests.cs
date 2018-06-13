using System;
using BankTellerExercise.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTellerExerciseTests.Classes
{
	[TestClass]
	public class CheckingAccountTests
	{

		[TestMethod]
		public void Withdraw()
		{		
			CheckingAccount _checkingAccount = new CheckingAccount();
			_checkingAccount.Deposit(100.00M);

			Assert.AreEqual(50.00M, _checkingAccount.Withdraw(50), "input" + ":Withdraw(50.00M)");
			Assert.AreEqual(-11.00M, _checkingAccount.Withdraw(51), "input" + ":Withdraw(51.00M)");
			Assert.AreEqual(-11.00M, _checkingAccount.Withdraw(100), "input" + ":Withdraw(100.00M)");
			Assert.AreEqual(-11.00M, _checkingAccount.Withdraw(1000), "input" + ":Withdraw(1000.00M)");

		}
	}
}
