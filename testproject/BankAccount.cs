using System;

namespace UnitTestingExamples.Library
{
	/// <summary>
	/// Bank account.
	/// </summary>
	public class BankAccount
	{
		private double m_balance = 0.0;

		public void Deposit(double amount)
		{
			m_balance += amount;
		}

		public double Balance
		{
			get { return m_balance; }
		}

		public void Withdraw(double amount)
		{
			if (m_balance - amount < 0)
				throw new ApplicationException(string.Format("Withdrawal amount {0} exceeds balance {1}", amount, m_balance));
			m_balance -= amount;
		}

		public void TransferFunds(BankAccount destination, double amount)
		{
			Withdraw(amount); // Do this first so destination balance is not changed if it fails.
			destination.Deposit(amount);
		}

		public void PayInterest(double percentage)
		{
			m_balance = Math.Round(Balance*(percentage/100.0 + 1),2);
		}
	}
}
