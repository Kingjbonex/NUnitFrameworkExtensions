using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitFrameworkExtensions.Parallelizable
{
	[TestFixture]
	public abstract class TestBase
	{
		[OneTimeSetUp]
		public void OneTimeSetUp()
		{
			Console.WriteLine(DateTime.Now.ToLongTimeString() + " :Setting up the suite..." + "\n");
			System.Threading.Thread.Sleep(500);
		}

		[OneTimeTearDown]
		public void OneTimeTearDown()
		{
			Console.WriteLine(DateTime.Now.ToLongTimeString() + " :Tearing down the suite..." + "\n");
		}

		[SetUp]
		public void SetUp()
		{
			Console.WriteLine(DateTime.Now.ToLongTimeString() + " :Setting up the test case..." + "\n");
			System.Threading.Thread.Sleep(500);
		}

		[TearDown]
		public void TearDown()
		{
			Console.WriteLine(DateTime.Now.ToLongTimeString() + " :Tearing down the test case..." + "\n");
			System.Threading.Thread.Sleep(500);
		}
	}
}
