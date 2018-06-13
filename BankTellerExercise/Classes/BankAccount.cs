using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
	public class BankAccount
	{
		//properties
		public string AccountNumber { get; set; }
		public decimal Balance { get; private set; }


		//constructor
		public BankAccount()
		{
			Balance = 0.0M;
		}


		//methods
		public virtual decimal Deposit(decimal amountToDeposit)
		{
			Balance += amountToDeposit;

			return Balance;
		}

		public virtual decimal Withdraw(decimal amountToWithdraw)
		{
			Balance -= amountToWithdraw;

			return Balance;
		}

		public void Transfer(BankAccount destinationAccount, decimal transferAmount)
		{
			this.Balance -= transferAmount;
			destinationAccount.Balance += transferAmount;
		}
	}
}
