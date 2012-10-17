using System;
using NUnit.Framework;
using UnitTestingExamples.Library;

namespace testprojectTests
{
	[TestFixture]
	public class AuditTrailTests
	{
		[Test]
		public void CreateAuditTrail_Basic()
		{
			var atv = new AuditTrail();
			Assert.AreEqual(0, atv.NumberOfTransactions, "Should start with no transactions.");
		}

		[Test]
		public void AddTransaction_Deposit()
		{
			var atv = new AuditTrail();
			double amount = 4.50;
			atv.AddTransaction(TransType.Deposit, amount);
			Assert.AreEqual(1, atv.NumberOfTransactions, "wrong number of transactions");
			Assert.AreEqual(amount, atv.TransactionLog[0].Amount, "wrong amount!");
		}
	}
}
