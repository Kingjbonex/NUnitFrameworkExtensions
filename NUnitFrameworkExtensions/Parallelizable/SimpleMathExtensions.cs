using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitFrameworkExtensions.Parallelizable
{
	[TestFixture, Parallelizable]
	public class SimpleMathFixture : TestBase
	{
		[TestCase(1, 2, 3),
		TestCase(2, 4, 6),
		TestCase(4, 4, 8)]
		public void CheckAddition(int x, int y, int expected)
		{
			System.Threading.Thread.Sleep(500);
			Assert.That(x + y == expected);
		}
	}
}
