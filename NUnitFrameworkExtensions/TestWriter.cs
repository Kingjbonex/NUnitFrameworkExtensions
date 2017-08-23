using System;
using System.IO;
using System.Xml;
using NUnit.Engine.Extensibility;

namespace NUnitFrameworkExtensions
{
	[Extension]
	[ExtensionProperty("Format", "TestNames")]
	public class TestWriter : IResultWriter
	{
		public void CheckWritability(string outputPath)
		{
			using (new FileStream(outputPath, FileMode.Create, FileAccess.Write))
			{
				// Opening is enough to check
			}
		}

		public void WriteResultFile(XmlNode resultNode, string outputPath)
		{
			using (var stream = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
			using (var writer = new StreamWriter(stream))
			{
				WriteResultFile(resultNode, writer);
			}
		}

		public void WriteResultFile(XmlNode resultNode, TextWriter writer)
		{
			foreach (XmlNode node in resultNode.SelectNodes("//test-case"))
				writer.WriteLine(node.Attributes["fullname"].Value);
		}
	}
}
