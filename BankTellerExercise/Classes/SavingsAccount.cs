using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
	public class SavingsAccount : BankAccount
	{
		public override decimal Withdraw(decimal amountToWithdraw)
		{
			
			if (base.Balance < amountToWithdraw)
			{
				amountToWithdraw = 0;
			}
			else if(base.Balance - amountToWithdraw < 150.00M)
			{
				amountToWithdraw += 2.00M;
			}

			return base.Withdraw(amountToWithdraw);
		}
	}
}
