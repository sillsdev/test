// Copyright (c) 2011, SIL International. All Rights Reserved.
// <copyright from='2011' to='2011' company='SIL International'>
// Copyright (c) 2011, SIL International. All Rights Reserved.
// Distributable under the terms of either the Common Public License or the
// GNU Lesser General Public License, as specified in the LICENSING.txt file.
// </copyright>
using System;

// more comments
// third line with a comment
namespace testproject
{
	class Base
	{
		public virtual int Method()
		{
			return 7;
		}
	}

	class Derived: Base
	{
		public override int Method()
		{
			return 8;
		}
	}

	/// <summary>
	/// A class to assist with conquering the universe.
	/// </summary>
	public class UniverseConqueror
	{
		private bool _conquered;

		public void Go()
		{
			if (_conquered)
				return;

			Console.WriteLine("Conquering the universe - muhahahah!");

			// TODO: flesh out method here.

			Console.WriteLine("Congratulations, you are now in control of the entire universe!");

			_conquered = true;
		}

		public bool AmIInCharge()
		{
			return _conquered;
		}
	}

	/// <summary>
	/// Main class for testing
	/// </summary>
	public class MainClass
	{
		/// <summary>
		/// Returns an arbitrary number
		/// </summary>
		public static int Number()
		{
			// a different comment in method Number()
			return 8;
		}

		/// <summary>
		/// Gets the name of the project
		/// </summary>
		public static string Name
		{
			get { return "TestProject"; }
		}

		/// <summary>
		/// Gets the description for the project
		/// </summary>
		public static string Project
		{
			get { return "This is the name of the project"; }
		}

		public static string Description
		{
			get { return "Project description";}
		}

		public static int Untested
		{
			get { return 1; }
		}

		public static int Some
		{
			get { return 2; }
		}

		public static int Three
		{
			get { return 3; }
		}
		
		public static int New
		{
			get { return 5; }
		}
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.WriteLine("This is a test.  This is only a test.  I repeat, this is a test!");
			var baseObj = new Base();
			var derivedObj = new Derived();
			Console.WriteLine("Base.Method() = {0}, but Derived.Method() = {1}.", baseObj.Method(), derivedObj.Method());
			var acct = new UnitTestingExamples.Library.BankAccount();
			acct.Deposit(1000000.00);
			acct.Withdraw(999999.99);
			Console.WriteLine("Account balance = ${0}.", acct.Balance);
			Console.WriteLine("(Now you know why banks don't use floating point arithmetic!)");

			var weapon = new UniverseConqueror();
			weapon.Go();
		}
	}
}

