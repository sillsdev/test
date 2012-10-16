using System;
using NUnit.Framework;
using UnitTestingExamples.Library;

namespace testprojectTests
{
	[TestFixture]
	public class AuditTrailTests
	{
		public void CreateAuditTrail_Basic()
		{
			var atv = new AuditTrail();
			Assert.AreEqual(0, atv.NumberOfTransactions, "Should start with no transactions.");
		}
	}
}
