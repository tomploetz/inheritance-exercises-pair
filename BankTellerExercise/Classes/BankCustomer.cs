using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
	public class BankCustomer
	{
		//properties
		public string Name { get; set; }
		public string Address { get; set; }
		public string PhoneNumber { get; set; }
		public decimal sum;
		List<BankAccount> accounts = new List<BankAccount>();
		
		public BankAccount[] Accounts
		{
			get
			{
				return accounts.ToArray();
			}
		}
		public bool IsVIP
		{
			get
			{
				//sum = 0;
				foreach (BankAccount item in accounts)
				{
					sum += item.Balance;
				}
				if(sum >= 25000)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}


		//methods
		public void AddAccount(BankAccount newAccount)
		{
			accounts.Add(newAccount);
		}
	}
}
