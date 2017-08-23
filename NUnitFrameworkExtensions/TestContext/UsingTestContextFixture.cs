using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitFrameworkExtensions
{
	[TestFixture]
	public class UsingTestContextFixture
	{
		[Test]
		public void GetRandomNumber()
		{
			int randomInt = TestContext.CurrentContext.Random.Next();
		}

		[TestCase(100),
		TestCase(500),
		TestCase(10)]
		public void GetRandomNumber(int max)
		{
			int randomInt = TestContext.CurrentContext.Random.Next(max);
			Assert.That(max > randomInt);
		}

		[TestCase(1, 100),
		TestCase(100, 1000),
		TestCase(-50, 50)]
		public void GetRandomNumer(int min, int max)
		{
			int randomInt = TestContext.CurrentContext.Random.Next(min, max);
			Assert.That(max > randomInt && min < randomInt);
		}
	}
}
