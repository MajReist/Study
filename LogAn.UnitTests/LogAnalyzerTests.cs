using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace LogAn.UnitTests
{
	[TestFixture]
	public class LogAnalyzerTests
	{
		[TestCase("filewithgoodextension.slf")]
		[TestCase("filewithgoodextension.SLF")]
		public void IsValidLogFileName_ValidExtensions_ReturnsTrue(string file)
		{
			LogAnalyzer analyzer = new LogAnalyzer();

			bool result = analyzer.IsValidLogFileName(file);

			Assert.True(result);
		}

		[TestCase("filewithgoodextension.slf", true)]
		[TestCase("filewithgoodextension.SLF", true)]
		[TestCase("filewithbadeextension.foo", false)]
		public void IsValidLogFileName_VariousExtensions_ReturnsTrue(string file, bool expected)
		{
			LogAnalyzer analyzer = new LogAnalyzer();

			bool result = analyzer.IsValidLogFileName(file);

			Assert.AreEqual(expected, result);
		}
	}
}
