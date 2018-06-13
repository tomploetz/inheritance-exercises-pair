using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
	public class CheckingAccount : BankAccount
	{
		public override decimal Withdraw(decimal amountToWithdraw)
		{
			if(base.Balance - amountToWithdraw < -100.00M)
			{
				amountToWithdraw = 0;
			}
			else if(base.Balance < amountToWithdraw)
			{
				amountToWithdraw += 10;
			}

			return base.Withdraw(amountToWithdraw);
		}	
	}
}
