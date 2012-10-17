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

		public List<Transaction> TransactionLog
		{
			get { return m_transactionList; }
		}

		public void AddTransaction(TransType deposit, double amount)
		{
			var trans = new Transaction() {TransactionType = TransType.Deposit, Amount = amount};
			m_transactionList.Add(trans);
		}
	}

	public class Transaction
	{
		public TransType TransactionType { get; set; }
		public double Amount { get; set; }
	}

	public enum TransType
	{
		Deposit,
		Withdrawal,
		Transfer
	}

}
