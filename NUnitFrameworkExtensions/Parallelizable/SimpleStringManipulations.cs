using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitFrameworkExtensions.Parallelizable
{
	[TestFixture, Parallelizable]
	public class SimpleStringManipulations : TestBase
	{
		[TestCase("This.That",'.',"This"),
		TestCase("That.This",'.',"That"),
		TestCase("That.That.And.This", '.', "That")]
		public void SimpleSplitString(string fullString, char splitChar, string firstSplitString)
		{
			string[] split = fullString.Split(splitChar);

			Assert.That(split[0].Equals(firstSplitString));
		}
	}
}
