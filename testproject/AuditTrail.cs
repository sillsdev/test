using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestingExamples.Library
{
	public class AuditTrail
	{
		private List<Transaction> m_transactionList;

		public AuditTrail()
		{
			m_transactionList = new List<Transaction>();
		}

		public int NumberOfTransactions { get { return m_transactionList.Count; } }
	}

	public class Transaction
	{
		public TransTypeEnum TransType { get; set; }
		public double Amount { get; set; }
	}

	public enum TransTypeEnum
	{
		Deposit,
		Withdrawal,
		Transfer
	}

}
