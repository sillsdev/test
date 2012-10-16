using System;
using NUnit.Framework;
using UnitTestingExamples.Library;

namespace UnitTestingExamples.Tests
{
	[TestFixture]
	public class BankAccountTests
	{
		[Test]
		public void TestDeposit()
		{
			BankAccount account = new BankAccount();
			account.Deposit(125.0);
			account.Deposit(25.0);
			Assert.AreEqual(150.0, account.Balance);
		}

		[Test]
		public void TestWithdraw()
		{
			BankAccount account = new BankAccount();
			account.Deposit(125.0);
			account.Withdraw(25.0);
			Assert.AreEqual(100.0, account.Balance);
		}

		[Test]
		public void WithdrawTooMuch_ThrowsApplicationException()
		{
			var account = new BankAccount();
			account.Deposit(25.0);
			Assert.Throws<ApplicationException>(() => account.Withdraw(30.0));
		}

		[Test]
		public void TransferFunds()
		{
			BankAccount source = new BankAccount();
			source.Deposit(200.00);
			BankAccount destination = new BankAccount();
			destination.Deposit(150.00);

			source.TransferFunds(destination, 100.00);
			Assert.AreEqual(250.00, destination.Balance);
			Assert.AreEqual(100.00, source.Balance);
		}

		[Test]
		public void Transfer_WithInadequateBalance_ThrowsArgumentException_MakesNoChanges()
		{
			var source = new BankAccount();
			source.Deposit(25.0);
			var destination = new BankAccount();
			destination.Deposit(100.0);

			Assert.Throws<ApplicationException>(() => source.TransferFunds(destination, 50.0));
			Assert.That(source.Balance, Is.EqualTo(25.0));
			Assert.That(destination.Balance, Is.EqualTo(100.0));
		}

		[Test]
		public void PayInterest_AddsAppropriateAmmountToBalance()
		{
			var source = new BankAccount();
			source.Deposit(25.0);
			source.PayInterest(10.0);
			Assert.That(source.Balance, Is.EqualTo(27.5));
		}
	}
}
