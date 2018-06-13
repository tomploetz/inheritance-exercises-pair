using System;
using BankTellerExercise.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTellerExerciseTests.Classes
{
	[TestClass]
	public class BankAccountTests
	{
		BankAccount _bankAccount = new BankAccount();
		
		[TestMethod]
		public void Deposit()
		{
			_bankAccount = new BankAccount();
			Assert.AreEqual(100.00M, _bankAccount.Deposit(100.00M), "input" + ":Deposit(100.00M)");
			Assert.AreEqual(-100.00M, _bankAccount.Deposit(-200.00M), "input" + ":Deposit(-200.00M)");
			Assert.AreEqual(999999999900.00M, _bankAccount.Deposit(1000000000000.00M), "input" + ":Deposit(1000000000000.00M)");	
		}

		[TestMethod]
		public void Withdraw()
		{
			_bankAccount = new BankAccount();
			Assert.AreEqual(-100.00M, _bankAccount.Withdraw(100.00M), "input" + ":Withdraw(100.00M)");
			_bankAccount = new BankAccount();
			Assert.AreEqual(-300.00M, _bankAccount.Withdraw(300.00M), "input" + ":Withdraw(-300.00M)");
			_bankAccount = new BankAccount();
			Assert.AreEqual(-1000000000000.00M, _bankAccount.Withdraw(1000000000000.00M), "input" + ":Withdraw(1000000000000.00M)");
		}

		[TestMethod]
		public void Transfer()
		{
			BankAccount destAcct = new BankAccount();
			_bankAccount = new BankAccount();
			_bankAccount.Transfer(destAcct, 100);

			Assert.AreEqual(-100.00M, _bankAccount.Balance, "input" + ":Withdraw(100.00M)");
			Assert.AreEqual(100.00M, destAcct.Balance, "input" + ":Withdraw(100.00M)");
		}
	}
}
